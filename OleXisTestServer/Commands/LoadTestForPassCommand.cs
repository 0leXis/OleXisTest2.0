using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string testFilename = null;
            int testSubject;
            if (result.Read())
            {
                if (!result.GetBoolean(2))
                {
                    error = CommandError.TestNotAvailable;
                    return null;
                }
                testFilename = result.GetInt32(0) + ".test";
                testSubject = result.GetInt32(1);
            }
            else
            {
                error = CommandError.TestNotFound;
                return null;
            }
            result.Close();

            var test = FileProcessor.LoadTestFile(testFilename);

            error = CommandError.None;
            return SequrityUtils.Encrypt(new NetSerializedTestInfo(test, testName, testSubject).ToJson(), client.SecretDFKey);
        }
    }
}
