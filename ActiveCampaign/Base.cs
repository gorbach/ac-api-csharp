using System;
using System.IO;
using System.Net;
using System.Text;
using ActiveCampaign.Models;
using ActiveCampaign.Struct;
using static System.Net.WebRequestMethods;

namespace ActiveCampaign
{
    public class Base
    {
        public Api Api;

        public string ReadStream(string url)
        {
            string data = null;

            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var apiStream = response.GetResponseStream();
                if (apiStream != null)
                {
                    var apiReader = new StreamReader(apiStream);
                    data = apiReader.ReadToEnd();
                    apiStream.Close();
                }
            }
            response.Close();

            if (Api.Debug)
            {
                Console.WriteLine(url);
                Console.WriteLine(data);
            }

            return data;
        }

        public string WriteStream(string url, string postStruct)
        {
            string data = null;

            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            request.UserAgent = "C# API Wrapper";
            request.Method = Http.Post;
            request.ContentType = "application/x-www-form-urlencoded";

            byte[] postArray = Encoding.UTF8.GetBytes(postStruct);
            request.ContentLength = postArray.Length;

            Stream apiStream = request.GetRequestStream();
            apiStream.Write(postArray, 0, postArray.Length);

            apiStream.Close();

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            apiStream = response.GetResponseStream();
            StreamReader apiReader = new StreamReader(apiStream);

            data = apiReader.ReadToEnd();

            apiReader.Close();
            apiStream.Close();
            response.Close();

            if (Api.Debug)
            {
                Console.WriteLine(url);
                Console.WriteLine(postStruct);
                Console.WriteLine(data);
            }

            return data;
        }

        public T SendRequest<T>(string url, string postStruct)
        {
            var response = WriteStream(url, postStruct);
            return XmlHelper.Deserialize<T>(response);
        }
    }
}