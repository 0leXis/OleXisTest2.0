using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTestServer
{
    static class AccessTokens
    {
        static private HashSet<string> userTokens = new HashSet<string>();
        static public string GenerateUserToken()
        {
            string token;
            var random = new Random();
            do
            {
                token = "";
                for (var i = 0; i < 256; i++)
                {
                    token += Convert.ToChar(random.Next(33, 126));
                }
            }
            while (userTokens.Contains(token));
            userTokens.Add(token);
            return token;
        }

        static public void DisposeUserToken(string token)
        {
            userTokens.Remove(token);
        }
    }
}
