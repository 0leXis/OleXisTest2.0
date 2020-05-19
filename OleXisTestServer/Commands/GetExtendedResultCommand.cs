using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetClasses;

namespace OleXisTestServer.Commands
{
    class GetExtendedResultCommand : ICommand
    {
        RequestInfo requestData;
        public GetExtendedResultCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var resultId = SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey);

            var result = DBConnection.PrepareExecProcedureCommand("GetExtendedResult", resultId).ExecuteReader();
            List<AnswerListItem> extendedResult = null;
            if (result.Read())
            {
                extendedResult = JsonConvert.DeserializeObject<List<AnswerListItem>>(Encoding.UTF8.GetString((byte[])result.GetValue(0)));
            }
            else
            {
                error = CommandError.TestResultNotFound;
                return null;
            }
            result.Close();

            error = CommandError.None;
            return SequrityUtils.Encrypt(JsonConvert.SerializeObject(extendedResult), client.SecretDFKey);
        }
    }
}
