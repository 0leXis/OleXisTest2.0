using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClasses
{
    public enum CommandError 
    { 
        None, 
        Unauthorized, 
        NoPermissions, 
        NullToken, ClientNotFound, 
        BadLoginOrPassword, 
        BadStudentGroup, 
        LoginExists, 
        TestNameBusy, 
        SubjectExists, 
        TestNotAvailable, 
        TestNotFound, 
        NoCurrentTest, 
        TestResultNotFound, 
        SelfRegistrationNotAllowed, 
        StudentRegistrationNotAllowed,
        TeacherRegistrationNotAllowed,
        GroupAddNotAllowed,
        SubjectAddNotAllowed,
        UserNotStudent
    }
    public static class CommandErrors
    {
        static private readonly Dictionary<string, string> ErrorMessages = new Dictionary<string, string>()
        {
            { null,  null },
            { "UNAUTHORIZED",  "Для выполнения данной команды необходимо выполнить вход" },
            { "NO_PERMISSIONS",  "У Вас недостаточно прав для выполнения данной команды" },
            { "NULL_TOKEN",  "Идентификатор пользователя не действителен" },
            { "CLIENT_NOT_FOUND",  "Пользователь не найден" },
            { "BAD_LOGIN_OR_PASSWORD",  "Неверный логин или пароль" },
            { "BAD_ST_GROUP",  "Группа/класс не существует" },
            { "LOGIN_EXISTS",  "Логин занят другим пользователем" },
            { "TEST_BUSY",  "Имя теста занято другим пользователем" },
            { "SUBJECT_EXISTS",  "Предмет/дисциплина с таким именем уже существует" },
            { "TEST_NOT_AVAILABLE",  "Тест недоступен" },
            { "TEST_NOT_FOUND",  "Тест не найден" },
            { "NO_CURRENT_TEST",  "Не найден тест, который вы выполняете" },
            { "TEST_RESULT_NOT_FOUND",  "Результат теста не найден" },
            { "SELF_REG_NOT_ALLOWED",  "Регистрация зарпрещена сервером" },
            { "STUDENT_REG_NOT_ALLOWED",  "Регистрация зарпрещена сервером" },
            { "TEACHER_REG_NOT_ALLOWED",  "Регистрация зарпрещена сервером" },
            { "GROUP_ADD_NOT_ALLOWED",  "Добавление группы запрещено сервером" },
            { "SUBJECT_ADD_NOT_ALLOWED",  "Добавление предмета/дисциплины запрещено сервером" },
            { "USER_NOT_STUDENT",  "Пользователь не является учащимся" }
        };

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
            { CommandError.SelfRegistrationNotAllowed,  "SELF_REG_NOT_ALLOWED" },
            { CommandError.StudentRegistrationNotAllowed,  "STUDENT_REG_NOT_ALLOWED" },
            { CommandError.TeacherRegistrationNotAllowed,  "TEACHER_REG_NOT_ALLOWED" },
            { CommandError.GroupAddNotAllowed,  "GROUP_ADD_NOT_ALLOWED" },
            { CommandError.SubjectAddNotAllowed,  "SUBJECT_ADD_NOT_ALLOWED" },
            { CommandError.UserNotStudent,  "USER_NOT_STUDENT" }
        };

        static public string GetErrorCode(CommandError error)
        {
            return Errors[error];
        }

        static public string GetErrorMessage(string error)
        {
            string errorMsg;
            try
            {
                errorMsg = ErrorMessages[error];
            }
            catch
            {
                return "Неизвестная ошибка";
            }
            return errorMsg;
        }
    }
}
