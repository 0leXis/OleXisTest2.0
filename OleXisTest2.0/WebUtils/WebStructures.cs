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
    public class RequestInfo
    {
        public string Command { get; }
        public string UserToken { get; }
        public byte[] Data { get; }
        public RequestInfo(string Command, byte[] Data, string UserToken)
        {
            this.Command = Command;
            if(Data != null)
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
        public string Firstname { get; }
        public string Lastname { get; }
        public string Role { get; }
        public string Group { get; }
        public AccountInfo(string Firstname, string Lastname, string Role, string Group)
        {
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
}