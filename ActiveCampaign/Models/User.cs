using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace ActiveCampaign.Models
{
    public class User : Base
    {
        public User(Api api)
        {
            Api = api;
        }

        public string Me()
        {
            var request = Api.AcUrl + "user_me";
            var response = ReadStream(request);
            return response;
        }

        public string Add(Struct.User user)
        {
            var request = Api.AcUrl + "user_add";

            string postData = "username=" + user.Username
                              + "&password=" + user.Password
                              + "&password_r=" + user.PasswordR
                              + "&email=" + HttpUtility.UrlEncode(user.Email)
                              + "&first_name=" + user.FirstName
                              + "&last_name=" + user.LastName;

            // Groups
            if (user.GroupDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> group in user.GroupDictionary)
                {
                    postData += "&group[" + group.Key + "]=" + group.Value;
                }
            }

            // Phone
            if (user.Phone != null)
            {
                postData += "&phone=" + user.Phone;
            }

            // Language
            if (user.Language != null)
            {
                postData += "&lang=" + user.Language;
            }

            // Timezone
            if (user.Timezone != null)
            {
                postData += "&timezone=" + user.Timezone;
            }

            var response = WriteStream(request, postData);

            return response;
        }
    }
}