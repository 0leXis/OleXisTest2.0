using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetClasses;

namespace OleXisTestServer.Commands
{
    class DeleteUserCommand : ICommand
    {
        RequestInfo requestData;
        public DeleteUserCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);
            if (client.Role != UserRoles.Admin)
            {
                error = CommandError.NoPermissions;
                return null;
            }

            var id = SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey);

            DBConnection.PrepareExecProcedureCommand("DeleteUser", id).ExecuteNonQuery();

            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
