using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleXisTestServer
{
    class AddSubjectCommand : ICommand
    {
        RequestInfo requestData;
        public AddSubjectCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            if (client.Role != UserRoles.Teacher && client.Role != UserRoles.Admin)
            {
                error = CommandError.NoPermissions;
                return null;
            }

            var SubjectName = SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey);

            var result = DBConnection.PrepareExecProcedureCommand("CheckSubject", SubjectName).ExecuteReader();
            if (result.Read())
            {
                error = CommandError.SubjectExists;
                return null;
            }
            result.Close();

            DBConnection.PrepareExecProcedureCommand("AddSubject", SubjectName).ExecuteNonQuery();

            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
