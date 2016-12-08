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

        public string Edit(Struct.User user)
        {
            var request = Api.AcUrl + "user_edit";

            string postData = "id=" + user.Id
                              + "username=" + user.Username
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
                postData += "&timezone=" + HttpUtility.UrlEncode(user.Timezone);
            }

            var response = WriteStream(request, postData);

            return response;
        }

        public string Delete(int id)
        {
            var request = Api.AcUrl + "user_delete&id=" + id;
            var response = ReadStream(request);
            return response;
        }

        public string DeleteMultiple(List<int> ids)
        {
            string joinedIds = string.Join(",", ids.Select(x => x.ToString()).ToArray());

            var request = Api.AcUrl + "user_delete&ids=" + joinedIds;
            var response = ReadStream(request);
            return response;
        }

        public string List(List<int> ids)
        {
            string joinedIds = string.Join(",", ids.Select(x => x.ToString()).ToArray());

            var request = Api.AcUrl + "user_list&ids=" + joinedIds;
            var response = ReadStream(request);
            return response;
        }

        public string View(int id)
        {
            var request = Api.AcUrl + "user_view&id=" + id;
            var response = ReadStream(request);
            return response;
        }

        public string ViewEmail(string email)
        {
            string emailFormat = HttpUtility.UrlEncode(email);

            var request = Api.AcUrl + "user_view_email&email=" + emailFormat;
            var response = ReadStream(request);
            return response;
        }

        public string ViewUsername(string username)
        {
            var request = Api.AcUrl + "user_view_email&username=" + username;
            var response = ReadStream(request);
            return response;
        }
    }
}