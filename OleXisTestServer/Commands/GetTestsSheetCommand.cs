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
    class GetTestsSheetCommand : ICommand
    {
        RequestInfo requestData;
        public GetTestsSheetCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var sheetParams = TestSheetGetParams.FromJson(SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey));
            if (client.Role != UserRoles.Teacher && sheetParams.isCreatorTests)
            {
                error = CommandError.NoPermissions;
                return null;
            }
            bool useNameFilter = false;
            bool useSubjectFilter = false;
            int subject = -1;
            string name = "";
            if (sheetParams.Name != null && sheetParams.Name != "")
            {
                name = sheetParams.Name;
                useNameFilter = true;
            }
            if (sheetParams.Subject != null && sheetParams.Subject > 0)
            {
                subject = sheetParams.Subject.Value;
                useSubjectFilter = true;
            }

            MySqlDataReader result;
            if(sheetParams.isCreatorTests)
                result = DBConnection.PrepareExecProcedureCommand("GetTestsCreatorSheet", client.UserId.ToString(), name, subject.ToString(), Convert.ToInt32(useNameFilter).ToString(), Convert.ToInt32(useSubjectFilter).ToString()).ExecuteReader();
            else
                result = DBConnection.PrepareExecProcedureCommand("GetTestsSheet", name, subject.ToString(), Convert.ToInt32(useNameFilter).ToString(), Convert.ToInt32(useSubjectFilter).ToString()).ExecuteReader();

            var testList = new List<TestSheetItem>();
            while (result.Read())
            {
                testList.Add(
                    new TestSheetItem(
                        result.GetInt32(0),
                        result.GetString(1),
                        result.GetString(2),
                        result.GetDateTime(3),
                        result.GetInt32(4),
                        result.GetBoolean(5)
                    ));
            }
            result.Close();

            error = CommandError.None;
            return SequrityUtils.Encrypt(JsonConvert.SerializeObject(testList), client.SecretDFKey);
        }
    }
}
