using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleXisTestServer
{
    public class RegisterTeacherCommand : ICommand
    {
        RequestInfo requestData;
        public RegisterTeacherCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            if(client.Role == null || client.Role == UserRoles.Student)
            {
                error = CommandError.NoPermissions;
                return null;
            }
            var registerData = RegisterData.FromJson(SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey));
            var passwordHash = SequrityUtils.GetHash(registerData.Password);

            var DBReader = DBConnection.PrepareExecProcedureCommand("CheckUserLogin", registerData.Login).ExecuteReader();
            if (DBReader.Read())
            {
                if (DBReader.GetInt32(0) > 0)
                {
                    DBReader.Close();
                    error = CommandError.LoginExists;
                    return null;
                }
            }
            DBReader.Close();
            DBConnection.PrepareExecProcedureCommand("RegisterTeacher", registerData.Firstname, registerData.Lastname, registerData.Login, passwordHash).ExecuteNonQuery();

            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
