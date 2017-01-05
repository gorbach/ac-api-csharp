using System.Collections.Generic;
using System.Web;

namespace ActiveCampaign.Models
{
    public class HttpHelper
    {
        public static string FormatValues<TKey, TValue>(string key, Dictionary<TKey, TValue> dict, bool addZero = false)
        {
            var postData = "";

            if (dict.Count > 0)
            {
                foreach (KeyValuePair<TKey, TValue> pair in dict)
                {
                    string k;
                    if (addZero)
                    {
                        k = $"{key}[{pair.Key.ToString()}, 0]";
                    }
                    else
                    {
                        k = $"{key}[{pair.Key.ToString()}]";
                    }

                    postData += $"&{HttpUtility.UrlEncode(k)}={HttpUtility.UrlEncode(pair.Value.ToString())}";
                }
            }
            return postData;
        }
    }
}