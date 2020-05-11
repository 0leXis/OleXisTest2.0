using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTestServer
{
    public enum CommandError { None, Unauthorized, NoPermissions, NullToken, ClientNotFound, BadLoginOrPassword, BadStudentGroup, LoginExists }
    public interface ICommand
    {
        byte[] Execute(out CommandError error);
    }
}
