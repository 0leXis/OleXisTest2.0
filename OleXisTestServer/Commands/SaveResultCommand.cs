using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using NetClasses;

namespace OleXisTestServer
{
    class SaveResultCommand : ICommand
    {
        RequestInfo requestData;
        public SaveResultCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            if (client.Role != UserRoles.Student)
            {
                error = CommandError.UserNotStudent;
                return null;
            }
            
            if(client.CurrentPassTestId == null)
            {
                error = CommandError.NoCurrentTest;
                return null;
            }

            var testResult = TestResult.FromJson(SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey));

            var command = DBConnection.GetCommand();
            command.CommandText = "call AddTestResult(@param0, @param1, @param2, @param3, @param4)";
            command.Parameters.Add(new MySqlParameter("@param0", client.CurrentPassTestId));
            command.Parameters.Add(new MySqlParameter("@param1", client.UserId));
            command.Parameters.Add(new MySqlParameter("@param2", testResult.Mark));
            command.Parameters.Add(new MySqlParameter("@param3", testResult.PassingTime));
            command.Parameters.Add(new MySqlParameter("@param4", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(testResult.Answers))));
            command.ExecuteNonQuery();

            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
