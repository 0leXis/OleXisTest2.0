using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleXisTestServer.Commands
{
    class PassToggleTestCommand : ICommand
    {
        RequestInfo requestData;
        public PassToggleTestCommand(RequestInfo requestData)
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

            var id = SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey);

            var result = DBConnection.PrepareExecProcedureCommand("CheckTestCreatorId", id).ExecuteReader();
            if (result.Read())
            {
                if(result.GetInt32(0) != client.UserId)
                {
                    error = CommandError.NoPermissions;
                    return null;
                }
            }
            else
            {
                error = CommandError.TestNotFound;
                return null;
            }
            result.Close();

            DBConnection.PrepareExecProcedureCommand("PassToggle", id).ExecuteNonQuery();

            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
