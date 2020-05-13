using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleXisTestServer
{
    public class RegisterStudentCommand : ICommand
    {
        RequestInfo requestData;
        public RegisterStudentCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var registerData = RegisterData.FromJson(SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey));
            var passwordHash = SequrityUtils.GetHash(registerData.Password);

            var DBReader = DBConnection.PrepareExecProcedureCommand("GetStudentGroup", registerData.Group).ExecuteReader();

            if (DBReader.Read())
            {
                var studentGroup = DBReader.GetInt32(0);
                DBReader.Close();

                DBReader = DBConnection.PrepareExecProcedureCommand("CheckUserLogin", registerData.Login).ExecuteReader();
                if (DBReader.Read())
                {
                    if(DBReader.GetInt32(0) > 0)
                    {
                        DBReader.Close();
                        error = CommandError.LoginExists;
                        return null;
                    }
                }
                DBReader.Close();
                DBConnection.PrepareExecProcedureCommand("RegisterStudent", registerData.Firstname, registerData.Lastname, registerData.Login, passwordHash, studentGroup.ToString()).ExecuteNonQuery();

                error = CommandError.None;
                return SequrityUtils.Encrypt("OK", client.SecretDFKey);
            }
            else
            {
                DBReader.Close();
                error = CommandError.BadStudentGroup;
                return null;
            }
        }
    }
}
