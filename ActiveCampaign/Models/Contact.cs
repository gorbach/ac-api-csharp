using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ActiveCampaign.Models
{
    public class Contact : Base
    {
        public Contact(Api api)
        {
            Api = api;
        }

        public string Add(Struct.Contact contact)
        {
            var request = Api.AcUrl + "contact_add";

            string postData =
                "email=" + HttpUtility.UrlEncode(contact.Email)
                + "&first_name=" + contact.FirstName
                + "&last_name=" + contact.LastName
                + "&phone=" + contact.Phone
                + "&orgname=" + contact.OrgName
                + "&tags=" + contact.Tags
                + "&ip4=" + contact.Ip4;

            if (contact.FieldDictionary.Count > 0)
            {
                foreach (KeyValuePair<string, string> pair in contact.FieldDictionary)
                {
                    postData += "&field[" + HttpUtility.UrlEncode(pair.Key) + "]=" + HttpUtility.UrlEncode(pair.Value);
                }
            }

            if (contact.ListDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.ListDictionary)
                {
                    postData += "&p[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.StatusDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.StatusDictionary)
                {
                    postData += "&status[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.Form > 0)
            {
                postData += "&form=" + contact.Form;
            }

            if (contact.NoRespondersDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.NoRespondersDictionary)
                {
                    postData += "&noresponders[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.SDateDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, string> pair in contact.SDateDictionary)
                {
                    postData += "&sdate[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.InstantRespondersDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.InstantRespondersDictionary)
                {
                    postData += "&instantresponders[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.LastMessageDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.LastMessageDictionary)
                {
                    postData += "&lastmessage[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            string response = WriteStream(request, postData);
            return response;
        }

        public string AutomationList(int Id, string email, int offset = 0, int limit = 20)
        {
            throw new NotImplementedException();
        }

        public string Delete(int Id = 0)
        {
            var request = Api.AcUrl + "contact_delete&id=" + Id;
            var response = ReadStream(request);
            return response;
        }

        public string DeleteList(List<int> idsList)
        {
            string joinedIds = string.Join(",", idsList.Select(x => x.ToString()).ToArray());

            var request = Api.AcUrl + "contact_delete_list&ids=" + joinedIds;
            var response = ReadStream(request);
            return response;
        }

        public string Edit(Struct.Contact contact)
        {
            var request = Api.AcUrl + "contact_add";

            string postData =
                "id=" + contact.Id
                + "email=" + HttpUtility.UrlEncode(contact.Email)
                + "&first_name=" + contact.FirstName
                + "&last_name=" + contact.LastName
                + "&phone=" + contact.Phone
                + "&orgname=" + contact.OrgName
                + "&tags=" + contact.Tags
                + "&ip4=" + contact.Ip4;

            if (contact.FieldDictionary.Count > 0)
            {
                foreach (KeyValuePair<string, string> pair in contact.FieldDictionary)
                {
                    postData += "&field[" + HttpUtility.UrlEncode(pair.Key) + "]=" + HttpUtility.UrlEncode(pair.Value);
                }
            }

            if (contact.ListDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.ListDictionary)
                {
                    postData += "&p[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.StatusDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.StatusDictionary)
                {
                    postData += "&status[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.Form > 0)
            {
                postData += "&form=" + contact.Form;
            }

            if (contact.NoRespondersDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.NoRespondersDictionary)
                {
                    postData += "&noresponders[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.SDateDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, string> pair in contact.SDateDictionary)
                {
                    postData += "&sdate[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.InstantRespondersDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.InstantRespondersDictionary)
                {
                    postData += "&instantresponders[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.LastMessageDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.LastMessageDictionary)
                {
                    postData += "&lastmessage[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            string response = WriteStream(request, postData);
            return response;
        }

        public string List(List<int> contactList, string filters = null, int full = 0, string sort = "id",
            string sortDirection = "DESC", int page = 20)
        {
            var request = Api.AcUrl + "contact_list";

            if (contactList.Count > 0)
            {
                string joinedIds = string.Join(",", contactList.Select(x => x.ToString()).ToArray());
                request += "&ids=" + joinedIds;
            }

            if (filters != null)
            {
                request += "&filters=" + filters;
            }

            request += "&full=" + full;
            request += "&sort=" + sort;
            request += "&sort_direction=" + sortDirection;
            request += "&page=" + page;

            var response = ReadStream(request);
            return response;
        }

        public string NoteAdd(int contactId, int listId, string note, Struct.Contact contact)
        {
            var request = Api.AcUrl + "contact_note_add";
            string postData =
                "id=" + contactId
                + "&listid=" + listId
                + "&note=" + HttpUtility.UrlEncode(note);

            if (contact.Email != null)
            {
                postData += "contact[email]=" + HttpUtility.UrlEncode(contact.Email);
            }

            var response = WriteStream(request, postData);
            return response;
        }

        public string NoteEdit(int contactId, int noteId, int listId, string note)
        {
            var request = Api.AcUrl + "contact_note_edit";
            var postData =
                "&subscriberid=" + contactId
                + "&listid=" + listId
                + "&noteid=" + noteId
                + "&note=" + HttpUtility.UrlEncode(note);

            var response = WriteStream(request, postData);
            return response;
        }

        public string NoteDelete(int noteId = 0)
        {
            var request = Api.AcUrl + "contact_note_delete&noteid=" + noteId;
            var response = ReadStream(request);
            return response;
        }

        public string Paginator(string sort = null, int offset = 20, int limit = 20, int filter = 0, int publicBool = 0)
        {
            var request = Api.AcUrl + "contact_paginator";
            request += "&sort=" + sort
                       + "&offset=" + offset
                       + "&limit=" + limit
                       + "&filter=" + filter
                       + "&public=" + publicBool;

            var response = ReadStream(request);
            return response;
        }

        public string Sync(Struct.Contact contact)
        {
            var request = Api.AcUrl + "contact_sync";

            string postData =
                "email=" + HttpUtility.UrlEncode(contact.Email)
                + "&first_name=" + contact.FirstName
                + "&last_name=" + contact.LastName
                + "&phone=" + contact.Phone
                + "&orgname=" + contact.OrgName
                + "&tags=" + contact.Tags
                + "&ip4=" + contact.Ip4;

            if (contact.FieldDictionary.Count > 0)
            {
                foreach (KeyValuePair<string, string> pair in contact.FieldDictionary)
                {
                    postData += "&field[" + HttpUtility.UrlEncode(pair.Key) + "]=" + HttpUtility.UrlEncode(pair.Value);
                }
            }

            if (contact.ListDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.ListDictionary)
                {
                    postData += "&p[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.StatusDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.StatusDictionary)
                {
                    postData += "&status[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.Form > 0)
            {
                postData += "&form=" + contact.Form;
            }

            if (contact.NoRespondersDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.NoRespondersDictionary)
                {
                    postData += "&noresponders[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.SDateDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, string> pair in contact.SDateDictionary)
                {
                    postData += "&sdate[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.InstantRespondersDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.InstantRespondersDictionary)
                {
                    postData += "&instantresponders[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            if (contact.LastMessageDictionary.Count > 0)
            {
                foreach (KeyValuePair<int, int> pair in contact.LastMessageDictionary)
                {
                    postData += "&lastmessage[" + HttpUtility.UrlEncode(pair.Key.ToString()) + "]=" +
                                HttpUtility.UrlEncode(pair.Value.ToString());
                }
            }

            string response = WriteStream(request, postData);
            return response;
        }

        public string TagAdd(Struct.Contact contact)
        {
            var request = Api.AcUrl + "contact_tag_add";

            string postData = null;

            if (contact.Email != null)
            {
                postData += "email=" + HttpUtility.UrlEncode(contact.Email) + "&";
            }

            if (contact.Id > 0)
            {
                postData += "id=" + contact.Id + "&";
            }

            if (contact.Tags.Count > 0)
            {
                postData += "tags=" + HttpUtility.UrlEncode(String.Join(",", contact.Tags.ToArray()));
            }

            var response = WriteStream(request, postData);
            return response;
        }

        public string TagRemove(Struct.Contact contact)
        {
            var request = Api.AcUrl + "contact_tag_remove";

            string postData = null;

            if (contact.Email != null)
            {
                postData += "&email=" + HttpUtility.UrlEncode(contact.Email);
            }

            if (contact.Id > 0)
            {
                postData += "&id=" + contact.Id;
            }

            if (contact.Tags.Count > 0)
            {
                postData += "&tags=" + HttpUtility.UrlEncode(string.Join(",", contact.Tags.ToArray()));
            }

            var response = WriteStream(request, postData);
            return response;
        }

        public string View(int id = 0)
        {
            var request = Api.AcUrl + "contact_view&id=" + id;
            var response = ReadStream(request);
            return response;
        }

        public string ViewEmail(string email = null)
        {
            var request = Api.AcUrl + "contact_view_email&email=" + HttpUtility.UrlEncode(email);
            var response = ReadStream(request);
            return response;
        }

        public string ViewHash(string hash = null)
        {
            var request = Api.AcUrl + "contact_view_hash&hash=" + HttpUtility.UrlEncode(hash);
            var response = ReadStream(request);
            return response;
        }
    }
}