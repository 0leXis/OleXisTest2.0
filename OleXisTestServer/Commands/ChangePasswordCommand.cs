using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetClasses;

namespace OleXisTestServer.Commands
{
    class ChangePasswordCommand : ICommand
    {
        RequestInfo requestData;
        public ChangePasswordCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var newPassword = SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey);
            var passwordHash = SequrityUtils.GetHash(newPassword);

            DBConnection.PrepareExecProcedureCommand("ChangePassword", client.UserId.ToString(), passwordHash).ExecuteNonQuery();

            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
