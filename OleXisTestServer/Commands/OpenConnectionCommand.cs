using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace OleXisTestServer
{
    public class OpenConnectionCommand : ICommand
    {
        RequestInfo requestData;
        public const char TOKEN_SEPARATOR = ' ';
        public OpenConnectionCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            CngKey dfKey;
            var publicKey = SequrityUtils.DiffieHellmanGetPublicKey(out dfKey);
            var userToken = ClientManager.CreateClient(dfKey);
            error = CommandError.None;
            return Encoding.UTF8.GetBytes(userToken + TOKEN_SEPARATOR + publicKey);
        }
    }
}
