using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using NetClasses;

namespace OleXisTestServer
{
    public class SetDFConnection : ICommand
    {
        RequestInfo requestData;

        public SetDFConnection(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            if(requestData.UserToken == null)
            {
                error = CommandError.NullToken;
                return null;
            }
            var client = ClientManager.GetClient(requestData.UserToken);
            if(client == null)
            {
                error = CommandError.ClientNotFound;
                return null;
            }
            client.SecretDFKey = SequrityUtils.DiffieHellmanGetSecretKey(Encoding.UTF8.GetString(requestData.Data), client.GeneratedDFKey);
            error = CommandError.None;
            return SequrityUtils.Encrypt("CONNECTION_STARTED", client.SecretDFKey);
        }
    }
}
