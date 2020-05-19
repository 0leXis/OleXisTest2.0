using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetClasses;

namespace OleXisTestServer
{
    public class DisconnectCommand : ICommand
    {
        RequestInfo requestData;
        public DisconnectCommand(RequestInfo requestData)
        {
            this.requestData = requestData;
        }
        public byte[] Execute(out CommandError error)
        {
            ClientManager.RemoveClient(requestData.UserToken);
            error = CommandError.None;
            return null;
        }
    }
}
