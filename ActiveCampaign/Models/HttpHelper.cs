using System.Collections.Generic;
using System.Web;

namespace ActiveCampaign.Models
{
    public class HttpHelper
    {
        public static string FormatValues<TKey, TValue>(string key, Dictionary<TKey, TValue> dict)
        {
            var postData = "";

            if (dict.Count > 0)
            {
                foreach (KeyValuePair<TKey, TValue> pair in dict)
                {
                    postData += $"&{key}[{HttpUtility.UrlEncode(pair.Key.ToString())}]={HttpUtility.UrlEncode(pair.Value.ToString())}";
                }
            }
            return postData;
        }
    }
}