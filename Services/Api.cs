using System;
using System.Net;
using System.IO;
using Entities;

namespace Services
{
    public class Api
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public enum httpVerb
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        public Api(string url, string key)
        {
            endPoint = url + key;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();
            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            
            return strResponseValue;
        }
    }
}
