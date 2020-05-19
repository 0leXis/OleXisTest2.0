using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using NetClasses;

namespace OleXisTestServer
{
    public class LoginCommand : ICommand
    {
        RequestInfo requestData;
        public LoginCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var loginData = LoginData.FromJson(SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey));
            var passwordHash = SequrityUtils.GetHash(loginData.Password);
            var result = DBConnection.PrepareExecProcedureCommand("CheckLoginInfo", loginData.Login, passwordHash).ExecuteReader();
            if (result.Read())
            {
                client.UserId = result.GetInt32(0);
                client.Role = (UserRoles)(result.GetInt32(4) - 1);
                var info = new AccountInfo(client.UserId, result.GetString(1), result.GetString(2), client.Role.Value, result.IsDBNull(5) ? null : result.GetString(5));

                client.UpdateExpiredTime();

                result.Close();
                error = CommandError.None;
                return SequrityUtils.Encrypt(info.ToJson(), client.SecretDFKey);
            }
            else
            {
                result.Close();
                error = CommandError.BadLoginOrPassword;
                return null;
            }
        }
    }
}
