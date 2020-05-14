using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace OleXisTest
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
}