using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    public class User
    {
        public string UserToken { get; }
        public byte[] SecretKey { get; set; }
        public User(string UserToken)
        {
            this.UserToken = UserToken;
        }
    }
}
