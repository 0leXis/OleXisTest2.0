using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetClasses;

namespace OleXisTest
{
    public class User
    {
        public int UserId { get; set; } = -1;
        public UserRoles UserRole { get; set; }
        public string UserToken { get; }
        public byte[] SecretKey { get; set; }
        public User(string UserToken)
        {
            this.UserToken = UserToken;
        }
    }
}
