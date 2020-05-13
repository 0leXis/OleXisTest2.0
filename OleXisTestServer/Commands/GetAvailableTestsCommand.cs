﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OleXisTestServer.Commands
{
    class GetAvailableTestsCommand : ICommand
    {
        RequestInfo requestData;
        public GetAvailableTestsCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);

            if (client.Role != UserRoles.Teacher)
            {
                error = CommandError.NoPermissions;
                return null;
            }

            var result = DBConnection.PrepareExecProcedureCommand("GetAvailableTests").ExecuteReader();
            var testsList = new List<string>();
            while (result.Read())
            {
                testsList.Add(result.GetString(0));
            }
            result.Close();

            error = CommandError.None;
            return SequrityUtils.Encrypt(JsonConvert.SerializeObject(testsList), client.SecretDFKey);
        }
    }
}