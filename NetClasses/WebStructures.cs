﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace NetClasses
{
    public enum UserRoles { Admin, Student, Teacher }
    public class RequestInfo
    {
        public string Command { get; }
        public string UserToken { get; }
        public byte[] Data { get; }
        public RequestInfo(string Command, byte[] Data, string UserToken)
        {
            this.Command = Command;
            if (Data != null)
            {
                this.Data = new byte[Data.Length];
                Data.CopyTo(this.Data, 0);
            }
            this.UserToken = UserToken;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public RequestInfo FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<RequestInfo>(Json);
        }
    }

    public class ResponseInfo
    {
        public string Error { get; }
        public byte[] Data { get; }
        public ResponseInfo(string Error, byte[] Data)
        {
            this.Error = Error;
            if (Data != null)
            {
                this.Data = new byte[Data.Length];
                Data.CopyTo(this.Data, 0);
            }
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public ResponseInfo FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<ResponseInfo>(Json);
        }
    }

    public class LoginData
    {
        public string Login { get; }
        public string Password { get; }
        public LoginData(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public LoginData FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<LoginData>(Json);
        }
    }

    public class RegisterData
    {
        public string Login { get; }
        public string Password { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public string Group { get; }
        public RegisterData(string Login, string Password, string Firstname, string Lastname, string Group)
        {
            this.Login = Login;
            this.Password = Password;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Group = Group;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public RegisterData FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<RegisterData>(Json);
        }
    }

    public class AccountInfo
    {
        public int UserId { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public UserRoles Role { get; }
        public string Group { get; }
        public AccountInfo(int UserId, string Firstname, string Lastname, UserRoles Role, string Group)
        {
            this.UserId = UserId;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Role = Role;
            this.Group = Group;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public AccountInfo FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<AccountInfo>(Json);
        }
    }

    public class NetSerializedTestInfo
    {
        public byte[] Test { get; }
        public string Name { get; }
        public int Subject { get; }
        public NetSerializedTestInfo(byte[] Test, string Name, int Subject)
        {
            this.Test = Test;
            this.Name = Name;
            this.Subject = Subject;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public NetSerializedTestInfo FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<NetSerializedTestInfo>(Json);
        }
    }

    public class TestSheetGetParams
    {
        public bool isCreatorTests;
        public string Name { get; }
        public int? Subject { get; }
        public TestSheetGetParams(bool isCreatorTests, string Name, int? Subject)
        {
            this.isCreatorTests = isCreatorTests;
            this.Name = Name;
            this.Subject = Subject;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public TestSheetGetParams FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<TestSheetGetParams>(Json);
        }
    }

    public class UserSheetGetParams
    {
        public string Surname { get; }
        public int? Role { get; }
        public UserSheetGetParams(string Surname, int? Role)
        {
            this.Surname = Surname;
            this.Role = Role;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public UserSheetGetParams FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<UserSheetGetParams>(Json);
        }
    }

    public class UserSheetItem
    {
        public int id { get; }
        public string Login { get; }
        public string Name { get; }
        public string Surname { get; }
        public int Role { get; }
        public string Group { get; }
        public UserSheetItem(int id, string Login, string Name, string Surname, int Role, string Group)
        {
            this.id = id;
            this.Login = Login;
            this.Name = Name;
            this.Surname = Surname;
            this.Role = Role;
            this.Group = Group;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public UserSheetGetParams FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<UserSheetGetParams>(Json);
        }
    }

    public class TestSheetItem
    {
        public int id { get; }
        public string Name { get; }
        public string Creator { get; }
        public DateTime EditDate { get; }
        public int Subject { get; }
        public bool PassAvailable { get; }
        public TestSheetItem(int id, string Name, string Creator, DateTime EditDate, int Subject, bool PassAvailable)
        {
            this.id = id;
            this.Name = Name;
            this.Creator = Creator;
            this.EditDate = EditDate;
            this.Subject = Subject;
            this.PassAvailable = PassAvailable;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public TestSheetItem FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<TestSheetItem>(Json);
        }
    }

    public class EditUserData
    {
        public int id { get; }
        public string Password { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public string Group { get; }
        public EditUserData(int id, string Password, string Firstname, string Lastname, string Group)
        {
            this.id = id;
            this.Password = Password;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Group = Group;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public EditUserData FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<EditUserData>(Json);
        }
    }

    public enum AnswerVariations
    {
        RightAnswerChoosed,
        WrongAnswerChoosed,
        RightAnswerNotChoosed,
        WrongAnswerNotChoosed,
        NoAnswer
    }

    public struct AnswerListVariant
    {
        public AnswerVariations Type { get; }
        public string VariantText { get; }

        public AnswerListVariant(AnswerVariations Type, string VariantText)
        {
            this.Type = Type;
            this.VariantText = VariantText;
        }
    }

    public class AnswerListItem
    {
        public string QuestionName { get; set; }
        public string QuestionDescription { get; set; }
        public List<AnswerListVariant> Variants { get; } = new List<AnswerListVariant>();
        public int Question_score { get; set; }
        public bool IsRight { get; set; }
    }

    public class TestResult
    {
        public int Mark { get; }
        public DateTime PassingTime { get; }
        public List<AnswerListItem> Answers { get; }
        public TestResult(int Mark, DateTime PassingTime, List<AnswerListItem> Answers)
        {
            this.Mark = Mark;
            this.PassingTime = PassingTime;
            this.Answers = Answers;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public TestResult FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<TestResult>(Json);
        }
    }

    public class ServerTestResultGetParams
    {
        public int TestId { get; }
        public string StudentSurname { get; }
        public DateTime? PassDate { get; }
        public ServerTestResultGetParams(int TestId, string StudentSurname, DateTime? PassDate)
        {
            this.TestId = TestId;
            this.StudentSurname = StudentSurname;
            this.PassDate = PassDate;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public ServerTestResultGetParams FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<ServerTestResultGetParams>(Json);
        }
    }

    public class ResultSheetItem
    {
        public int id { get; }
        public string NameSurname { get; }
        public int Mark { get; }
        public DateTime PassingTime { get; }
        public DateTime PassDate { get; }
        public ResultSheetItem(int id, string NameSurname, int Mark, DateTime PassingTime, DateTime PassDate)
        {
            this.id = id;
            this.NameSurname = NameSurname;
            this.Mark = Mark;
            this.PassingTime = PassingTime;
            this.PassDate = PassDate;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public ResultSheetItem FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<ResultSheetItem>(Json);
        }
    }

    public class ExtendedResultSheetItem
    {
        public int id { get; }
        public string NameSurname { get; }
        public int Mark { get; }
        public DateTime PassingTime { get; }
        public DateTime PassDate { get; }
        public List<AnswerListItem> ExtendedResult { get; }
        public ExtendedResultSheetItem(int id, string NameSurname, int Mark, DateTime PassingTime, DateTime PassDate, List<AnswerListItem> ExtendedResult)
        {
            this.id = id;
            this.NameSurname = NameSurname;
            this.Mark = Mark;
            this.PassingTime = PassingTime;
            this.PassDate = PassDate;
            this.ExtendedResult = ExtendedResult;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        static public ExtendedResultSheetItem FromJson(string Json)
        {
            return JsonConvert.DeserializeObject<ExtendedResultSheetItem>(Json);
        }
    }
}
