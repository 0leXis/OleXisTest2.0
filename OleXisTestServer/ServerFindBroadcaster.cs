using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace OleXisTestServer
{
    public class ServerFindBroadcaster
    {
        private UdpClient udpClient;
        private CancellationTokenSource cancelToken;
        public int ServerPort { get; }
        public int BroadcastPort { get; }
        public ServerFindBroadcaster(int ServerPort, int BroadcastPort)
        {
            this.BroadcastPort = BroadcastPort;
            this.ServerPort = ServerPort;
            udpClient = new UdpClient(BroadcastPort);
            udpClient.EnableBroadcast = true;
        }

        public void StartBroadcast()
        {
            cancelToken = new CancellationTokenSource();

            Task.Factory.StartNew(() => { Broadcast(cancelToken.Token); });
        }

        public void StopBroadcast()
        {
            if(cancelToken != null)
            {
                cancelToken.Cancel();
                cancelToken = null;
                udpClient.Close();
            }
        }

        private void Broadcast(CancellationToken token)
        {
            var response = Encoding.UTF8.GetBytes(ServerPort.ToString());
            while (true)
            {
                try
                {
                    if (token.IsCancellationRequested)
                        return;
                    if (udpClient.Available > 0)
                    {
                        var IP = new IPEndPoint(IPAddress.Any, BroadcastPort);
                        var result = udpClient.Receive(ref IP);
                        if (Encoding.UTF8.GetString(result) == "GET_SERVER_IP")
                            udpClient.Send(response, response.Length, IP);
                    }
                    Thread.Sleep(1);
                }
                catch { }
            }
        }
    }
}
