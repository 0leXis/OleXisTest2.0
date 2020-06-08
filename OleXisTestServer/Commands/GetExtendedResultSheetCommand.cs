using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetClasses;

namespace OleXisTestServer.Commands
{
    class GetExtendedResultSheetCommand : ICommand
    {
        RequestInfo requestData;
        public GetExtendedResultSheetCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var testId = SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey);

            var result = DBConnection.PrepareExecProcedureCommand("GetExtendedResultSheet", testId).ExecuteReader();
            List<ExtendedResultSheetItem> extendedResults = new List<ExtendedResultSheetItem>();
            while (result.Read())
            {
                var tmpDateTime = result.GetString(3).Split(':');
                var passingTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(tmpDateTime[0]), Convert.ToInt32(tmpDateTime[1]), Convert.ToInt32(tmpDateTime[2]));
                extendedResults.Add(
                    new ExtendedResultSheetItem(
                        result.GetInt32(0),
                        result.GetString(1),
                        result.GetInt32(2),
                        passingTime,
                        result.GetDateTime(4),
                        JsonConvert.DeserializeObject<List<AnswerListItem>>(Encoding.UTF8.GetString((byte[])result.GetValue(5)))
                    ));
            }
            result.Close();

            error = CommandError.None;
            return SequrityUtils.Encrypt(JsonConvert.SerializeObject(extendedResults), client.SecretDFKey);
        }
    }
}
