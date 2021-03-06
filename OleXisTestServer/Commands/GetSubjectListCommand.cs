﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NetClasses;

namespace OleXisTestServer
{
    class GetSubjectListCommand : ICommand
    {
        RequestInfo requestData;
        public GetSubjectListCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);
            
            var result = DBConnection.PrepareExecProcedureCommand("GetSubjectList").ExecuteReader();
            var subjectList = new Dictionary<int, string>();
            while (result.Read())
            {
                subjectList.Add(result.GetInt32(0), result.GetString(1));
            }
            result.Close();

            error = CommandError.None;
            return SequrityUtils.Encrypt(JsonConvert.SerializeObject(subjectList), client.SecretDFKey);
        }
    }
}
