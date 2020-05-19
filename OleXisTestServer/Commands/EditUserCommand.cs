using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetClasses;

namespace OleXisTestServer.Commands
{
    class EditUserCommand : ICommand
    {
        RequestInfo requestData;
        public EditUserCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);
            if(client.Role != UserRoles.Admin)
            {
                error = CommandError.NoPermissions;
                return null;
            }

            var editData = EditUserData.FromJson(SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey));
            string password = "";
            bool changePassword = false;
            if(editData.Password != null)
            {
                password = SequrityUtils.GetHash(editData.Password);
                changePassword = true;
            }

            UserRoles role;
            var DBReader = DBConnection.PrepareExecProcedureCommand("GetUserRole", editData.id.ToString()).ExecuteReader();
            if (DBReader.Read())
            {
                role = (UserRoles)DBReader.GetInt32(0) - 1;
            }
            else
            {
                error = CommandError.ClientNotFound;
                return null;
            }
            DBReader.Close();

            int studentGroup = -1;
            bool changeGroup = false;
            if (role == UserRoles.Student)
            {
                changeGroup = true;
                DBReader = DBConnection.PrepareExecProcedureCommand("GetStudentGroup", editData.Group).ExecuteReader();

                if (DBReader.Read())
                {
                    studentGroup = DBReader.GetInt32(0);
                    DBReader.Close();
                }
                else
                {
                    DBReader.Close();
                    error = CommandError.BadStudentGroup;
                    return null;
                }
            }

            DBConnection.PrepareExecProcedureCommand("EditUser", editData.id.ToString(), editData.Firstname, editData.Lastname, password, studentGroup.ToString(), Convert.ToInt32(changePassword).ToString(), Convert.ToInt32(changeGroup).ToString()).ExecuteNonQuery();

            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
