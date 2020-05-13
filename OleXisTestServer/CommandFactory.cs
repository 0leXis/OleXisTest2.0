using OleXisTestServer.Commands;
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
                case "RegisterTeacher":
                    return new RegisterTeacherCommand(requestData);
                case "Disconnect":
                    return new DisconnectCommand(requestData);
                case "UpdateTime":
                    return new UpdateTokenCommand(requestData);
                case "SaveTest":
                    return new SaveTestCommand(requestData);
                case "AddSubject":
                    return new AddSubjectCommand(requestData);
                case "GetSubjectList":
                    return new GetSubjectListCommand(requestData);
                case "GetMyTests":
                    return new GetMyTestsCommand(requestData);
                case "GetAvailableTests":
                    return new GetAvailableTestsCommand(requestData);
                case "LoadTestForPass":
                    return new LoadTestForPassCommand(requestData);
                case "LoadTestForEdit":
                    return new LoadTestForEditCommand(requestData);
                default:
                    throw new ArgumentException("Получена неверная команда");
            }
        }
    }
}
