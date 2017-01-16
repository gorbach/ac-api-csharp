using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveCampaign.Helpers
{
    public class HttpHelper
    {
        public static string FormatValues<TKey, TValue>(string key, Dictionary<TKey, TValue> dict, bool addZero = false)
        {
            var postData = "";

            if (dict == null || dict.Count <= 0) return postData;

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
            return postData;
        }

        public static string IdsStr(params int[] ids)
        {
            var idsStr = "all";

            if (ids != null && ids.Any())
            {
                idsStr = string.Join(",", ids.Select(x => x.ToString()).ToArray());
            }
            return idsStr;
        }

        public static string Bool(bool value)
        {
            return value ? "1" : "0";
        }

        public static string Date(DateTime? value)
        {
            if (value == null) return "";
            return value.Value.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}