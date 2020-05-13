using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OleXisTest
{
    public class TokenUpdator
    {
        Thread checkExpiredThread;
        DateTime expiredTime;
        object lockObject = new object();
        NetConnection connection;

        public TokenUpdator(NetConnection connection) 
        {
            this.connection = connection;
        }
        public void Start()
        {
            Stop();
            expiredTime = DateTime.Now.AddMinutes(3);
            checkExpiredThread = new Thread(new ThreadStart(CheckExpired));
            checkExpiredThread.Start();
        }
        private void CheckExpired()
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (expiredTime < DateTime.Now)
                        connection.SendCommand(new RequestInfo("UpdateTime", null, connection.User.UserToken), onRecive);
                }
                Thread.Sleep(1000);
            }
        }

        private void onRecive(string responseData)
        {
            var responseInfo = ResponseInfo.FromJson(responseData);
            if (SequrityUtils.DecryptString(responseInfo.Data, connection.User.SecretKey) == "OK")
                expiredTime = expiredTime.AddMinutes(3);
        }

        public void Stop()
        {
            if (checkExpiredThread != null && checkExpiredThread.IsAlive)
                checkExpiredThread.Abort();
        }
    }
}
