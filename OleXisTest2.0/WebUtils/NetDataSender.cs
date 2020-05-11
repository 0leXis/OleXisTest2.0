using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace OleXisTest
{
    class NetDataSender
    {
        Action<string> getResponseAction;
        public NetDataSender(RequestInfo requestData, Action<string> getResponseAction, string Url)
        {
            this.getResponseAction = getResponseAction;
            var request = WebRequest.Create(Url);
            request.Method = "POST";

            string data = requestData.ToJson();
            byte[] byteArray = Encoding.UTF8.GetBytes(data);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            request.BeginGetResponse(new AsyncCallback(OnGetResponse), request);
        }

        private void OnGetResponse(IAsyncResult result)
        {
                // Set the State of request to asynchronous.
                WebRequest request = (WebRequest)result.AsyncState;
                // End the Asynchronous response.
                var response = request.EndGetResponse(result);
                // Read the response into a 'Stream' object.
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    getResponseAction(reader.ReadToEnd());
                }
                response.Close();
        }
    }
}
