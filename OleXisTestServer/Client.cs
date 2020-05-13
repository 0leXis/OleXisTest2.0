using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Security.Cryptography;

namespace OleXisTestServer
{
    public class Client : IDisposable
    {
        public const int START_EXPIRED_TIME = 1;
        public const int LOGINED_EXPIRED_TIME = 4;
        public string UserToken { get; set; }
        public int UserId { get; set; }
        public UserRoles? Role { get; set; } = null;
        public CngKey GeneratedDFKey { get; set; }
        public byte[] SecretDFKey { get; set; }
        public DateTime ExpiredTime { get; set; }
        public Client(CngKey GeneratedDFKey)
        {
            this.GeneratedDFKey = GeneratedDFKey;
            UserToken = AccessTokens.GenerateUserToken();
            ExpiredTime = DateTime.Now.AddMinutes(START_EXPIRED_TIME);
        }
        public void UpdateExpiredTime()
        {
            ExpiredTime = DateTime.Now.AddMinutes(LOGINED_EXPIRED_TIME);
        }
        public void Dispose()
        {
            AccessTokens.DisposeUserToken(UserToken);
        }

        ~Client()
        {
            Dispose();
        }
    }
}
