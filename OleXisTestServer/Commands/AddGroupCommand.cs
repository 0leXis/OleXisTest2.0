using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetClasses;

namespace OleXisTestServer
{
    class AddGroupCommand : ICommand
    {
        RequestInfo requestData;
        public AddGroupCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var config = ConfigContainer.GetConfig();
            if (client.Role == UserRoles.Teacher && !config.AllowGroupsAdding)
            {
                error = CommandError.GroupAddNotAllowed;
                return null;
            }

            if (client.Role != UserRoles.Teacher && client.Role != UserRoles.Admin)
            {
                error = CommandError.NoPermissions;
                return null;
            }

            var groupName = SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey);

            var result = DBConnection.PrepareExecProcedureCommand("CheckGroup", groupName).ExecuteReader();
            if (result.Read())
            {
                error = CommandError.SubjectExists;
                return null;
            }
            result.Close();

            DBConnection.PrepareExecProcedureCommand("AddGroup", groupName).ExecuteNonQuery();

            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
