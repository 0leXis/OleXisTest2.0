using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetClasses;

namespace OleXisTestServer
{
    public class UpdateTokenCommand : ICommand
    {
        RequestInfo requestData;
        public UpdateTokenCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            var client = ClientManager.GetClient(requestData.UserToken);
            client.UpdateExpiredTime();
            error = CommandError.None;
            return SequrityUtils.Encrypt("OK", client.SecretDFKey);
        }
    }
}
