using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleXisTestServer.Commands
{
    public class SaveTestCommand : ICommand
    {
        RequestInfo requestData;
        public SaveTestCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);
            if (client.Role != UserRoles.Teacher)
            {
                error = CommandError.NoPermissions;
                return null;
            }
            var testData = NetSerializedTestInfo.FromJson(SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey));

            var result = DBConnection.PrepareExecProcedureCommand("GetCreatorIdAndLastTestNumber", testData.Name).ExecuteReader();
            var testFileId = 1;
            if (result.Read())
            {
                if (!result.IsDBNull(0))
                    if(result.GetInt32(0) != client.UserId)
                    {
                        error = CommandError.TestNameBusy;
                        return null;
                    }
                if (!result.IsDBNull(0))
                    testFileId = result.GetInt32(1) + 1;
            }
            result.Close();
            //TODO: Если тест с таким именем уже существует, отправить запрос на перезапись
            FileProcessor.SaveTestFile(testFileId + ".test", testData.Test);
            DBConnection.PrepareExecProcedureCommand("SaveTest", testData.Name, client.UserId.ToString(), testData.Subject.ToString()).ExecuteNonQuery();

            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
