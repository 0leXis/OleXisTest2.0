using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleXisTestServer
{
    public enum CommandError { None, Unauthorized, NoPermissions, NullToken, ClientNotFound, BadLoginOrPassword, BadStudentGroup, LoginExists, TestNameBusy, SubjectExists, TestNotAvailable, TestNotFound, NoCurrentTest, TestResultNotFound }
    public static class CommandErrors
    {
        static private readonly Dictionary<CommandError, string> Errors = new Dictionary<CommandError, string>()
        {
            { CommandError.None,  null },
            { CommandError.Unauthorized,  "UNAUTHORIZED" },
            { CommandError.NoPermissions,  "NO_PERMISSIONS" },
            { CommandError.NullToken,  "NULL_TOKEN" },
            { CommandError.ClientNotFound,  "CLIENT_NOT_FOUND" },
            { CommandError.BadLoginOrPassword,  "BAD_LOGIN_OR_PASSWORD" },
            { CommandError.BadStudentGroup,  "BAD_ST_GROUP" },
            { CommandError.LoginExists,  "LOGIN_EXISTS" },
            { CommandError.TestNameBusy,  "TEST_BUSY" },
            { CommandError.SubjectExists,  "SUBJECT_EXISTS" },
            { CommandError.TestNotAvailable,  "TEST_NOT_AVAILABLE" },
            { CommandError.TestNotFound,  "TEST_NOT_FOUND" },
            { CommandError.NoCurrentTest,  "NO_CURRENT_TEST" },
            { CommandError.TestResultNotFound,  "TEST_RESULT_NOT_FOUND" },
        };

        static public string GetErrorCode(CommandError error)
        {
            return Errors[error];
        }
    }
}
