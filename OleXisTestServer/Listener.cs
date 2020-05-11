using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace OleXisTestServer
{
    public class Listener
    {
        HttpListener listener;
        CancellationTokenSource cancelTokenSource;
        ILog log;
        public Listener(ILog log)
        {
            this.log = log;
            listener = new HttpListener();
        }

        public void ListenStart(string uri)
        {
            listener.Prefixes.Add(uri);
            listener.Start();
            cancelTokenSource = new CancellationTokenSource();
            Task.Factory.StartNew(() => { Listen(cancelTokenSource.Token); });
        }

        public void ListenStop()
        {
            if(cancelTokenSource != null)
            {
                cancelTokenSource.Cancel();
                listener.Stop();
                cancelTokenSource = null;
            }
        }

        private void Listen(CancellationToken token)
        {
            IAsyncResult result = null;
            while (true)
            {
                if (token.IsCancellationRequested)
                    return;
                if (result == null || result.IsCompleted)
                    result = listener.BeginGetContext(new AsyncCallback(OnGetContext), listener);
                Thread.Sleep(1);
            }
        }

        private void OnGetContext(IAsyncResult result)
        {
            try
            {
                HttpListener listener = (HttpListener)result.AsyncState;
                HttpListenerContext context = listener.EndGetContext(result);

                HttpListenerRequest request = context.Request;
                log.LogMessage("Запрос от " + request.RemoteEndPoint.Address.ToString());

                HttpListenerResponse response = context.Response;
                ResponseInfo responseData;
                if (request.HttpMethod != "POST")
                {
                    log.LogError("Запрос использует недопустимый метод");
                    responseData = new ResponseInfo("BADMETHOD", null);
                }
                else
                {
                    CommandError error;
                    var postData = GetRequestPostData(request);
                    RequestInfo requestData = null;
                    try
                    {
                        requestData = RequestInfo.FromJson(postData);
                        responseData = new ResponseInfo(null, CommandFactory.GetCommand(requestData).Execute(out error));
                        if (error != CommandError.None)
                        {
                            log.LogError("TODO: фабрика ошибок");
                            responseData = new ResponseInfo("BADCOMMAND", null);
                        }
                    }
                    catch(Exception e)
                    {
                        log.LogError(e.ToString());
                        responseData = new ResponseInfo("BADJSON", null);
                    }
                }
                var responseString = responseData.ToJson();
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }
            catch(HttpListenerException e)
            {
                if (e.ErrorCode != 995)
                    throw e;
            }
        }

        private static string GetRequestPostData(HttpListenerRequest request)
        {
            if (!request.HasEntityBody)
            {
                return null;
            }
            using (Stream stream = request.InputStream)
            {
                using (StreamReader reader = new StreamReader(stream, request.ContentEncoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
