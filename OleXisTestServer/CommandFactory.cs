using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTestServer
{
    static class CommandFactory
    {
        static public ICommand GetCommand(RequestInfo requestData)
        {
            switch (requestData.Command)
            {
                case "OpenConnection":
                    return new OpenConnectionCommand(requestData);
                case "SetDF":
                    return new SetDFConnection(requestData);
                case "Login":
                    return new LoginCommand(requestData);
                case "RegisterStudent":
                    return new RegisterStudentCommand(requestData);
                case "Disconnect":
                    return new DisconnectCommand(requestData);
                case "UpdateTime":
                    return new UpdateTokenCommand(requestData);
                default:
                    throw new ArgumentException("Получена неверная команда");
            }
        }
    }
}
