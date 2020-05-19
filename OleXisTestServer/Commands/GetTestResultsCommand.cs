using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NetClasses;

namespace OleXisTestServer
{
    class GetTestResultsCommand : ICommand
    {
        RequestInfo requestData;
        public GetTestResultsCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            var resultParams = ServerTestResultGetParams.FromJson(SequrityUtils.DecryptString(requestData.Data, client.SecretDFKey));

            
            bool useSurnameFilter = false;
            bool useDateFilter = false;
            DateTime date = DateTime.Now;
            string surname = "";
            if (resultParams.StudentSurname != null && resultParams.StudentSurname != "")
            {
                surname = resultParams.StudentSurname;
                useSurnameFilter = true;
            }
            if (resultParams.PassDate != null)
            {
                date = resultParams.PassDate.Value;
                useDateFilter = true;
            }

            var result = DBConnection.PrepareExecProcedureCommand("GetTestResultSheet", surname, date.ToString("yyyy-MM-dd"), Convert.ToInt32(useSurnameFilter).ToString(), Convert.ToInt32(useDateFilter).ToString()).ExecuteReader();

            var resultList = new List<ResultSheetItem>();
            while (result.Read())
            {
                var tmpDateTime = result.GetString(3).Split(':');
                var passingTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(tmpDateTime[0]), Convert.ToInt32(tmpDateTime[1]), Convert.ToInt32(tmpDateTime[2]));
                resultList.Add(
                    new ResultSheetItem(
                        result.GetInt32(0),
                        result.GetString(1),
                        result.GetInt32(2),
                        passingTime,
                        result.GetDateTime(4)
                    ));
            }
            result.Close();

            error = CommandError.None;
            return SequrityUtils.Encrypt(JsonConvert.SerializeObject(resultList), client.SecretDFKey);
        }
    }
}
