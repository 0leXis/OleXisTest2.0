using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetClasses;

namespace OleXisTestServer.Commands
{
    class LoadTestForPassCommand : ICommand
    {
        RequestInfo requestData;
        public LoadTestForPassCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var testName = SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey);
            var result = DBConnection.PrepareExecProcedureCommand("CheckTestAvailability", testName).ExecuteReader();
            int? testId = null;
            int testSubject;
            if (result.Read())
            {
                if (!result.GetBoolean(2))
                {
                    error = CommandError.TestNotAvailable;
                    return null;
                }
                testId = result.GetInt32(0);
                testSubject = result.GetInt32(1);
            }
            else
            {
                error = CommandError.TestNotFound;
                return null;
            }
            result.Close();

            var test = FileProcessor.LoadTestFile(testId + ".test");
            client.CurrentPassTestId = testId;

            error = CommandError.None;
            return SequrityUtils.Encrypt(new NetSerializedTestInfo(test, testName, testSubject).ToJson(), client.SecretDFKey);
        }
    }
}
