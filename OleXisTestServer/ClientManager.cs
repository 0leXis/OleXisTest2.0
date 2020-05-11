using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OleXisTestServer
{
    static class ClientManager
    {
        static private List<Client> Clients { get; set; } = new List<Client>();
        static private object lockObject = new object();
        static ClientManager()
        {
            Task.Factory.StartNew(RemoveExpiredClients);
        }

        static public string CreateClient(CngKey GeneratedDFKey)
        {
            lock (lockObject)
            {
                Clients.Add(new Client(GeneratedDFKey));
                return Clients.Last().UserToken;
            }
        }

        static public void RemoveClient(string ClientToken)
        {
            lock (lockObject)
            {
                var index = Clients.FindIndex((x) => x.UserToken == ClientToken);
                Clients[index].Dispose();
                Clients.RemoveAt(index);
            }
        }

        static public Client GetClient(string ClientToken)
        {
            lock (lockObject)
            {
                var index = Clients.FindIndex((x) => x.UserToken == ClientToken);
                if (index == -1)
                    return null;
                if (Clients[index].ExpiredTime.Minute - DateTime.Now.Minute < Client.START_EXPIRED_TIME)
                    Clients[index].ExpiredTime = Clients[index].ExpiredTime.AddMinutes(Client.START_EXPIRED_TIME);
                return Clients[index];
            }
        }

        static private void RemoveExpiredClients()
        {
            while (true)
            {
                lock (lockObject)
                {
                    for(var i = 0; i < Clients.Count; i++)
                        if(Clients[i].ExpiredTime < DateTime.Now)
                        {
                            Clients[i].Dispose();
                            Clients.RemoveAt(i);
                            i--;
                        }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
