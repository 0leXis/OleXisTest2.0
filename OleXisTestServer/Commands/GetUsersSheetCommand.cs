using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NetClasses;

namespace OleXisTestServer
{
    class GetUsersSheetCommand : ICommand
    {
        RequestInfo requestData;
        public GetUsersSheetCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var sheetParams = UserSheetGetParams.FromJson(SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey));
            bool useSurnameFilter = false;
            bool useRoleFilter = false;
            int role = -1;
            string surname = "";
            if (sheetParams.Surname != null && sheetParams.Surname != "")
            {
                surname = sheetParams.Surname;
                useSurnameFilter = true;
            }
            if (sheetParams.Role != null && sheetParams.Role > 0)
            {
                role = sheetParams.Role.Value;
                useRoleFilter = true;
            }

            var result = DBConnection.PrepareExecProcedureCommand("GetUsersSheet", surname, role.ToString(), Convert.ToInt32(useSurnameFilter).ToString(), Convert.ToInt32(useRoleFilter).ToString()).ExecuteReader();
            var userList = new List<UserSheetItem>();
            while (result.Read())
            {
                userList.Add(
                    new UserSheetItem(
                        result.GetInt32(0),
                        result.GetString(1),
                        result.GetString(2),
                        result.GetString(3),
                        result.GetInt32(4),
                        result.IsDBNull(5) ? null : result.GetString(5)
                    ));
            }
            result.Close();

            error = CommandError.None;
            return SequrityUtils.Encrypt(JsonConvert.SerializeObject(userList), client.SecretDFKey);
        }
    }
}
