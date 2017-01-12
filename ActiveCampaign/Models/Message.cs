using System.Collections.Generic;
using System.Linq;
using ActiveCampaign.Responses;
using ActiveCampaign.Struct;

namespace ActiveCampaign.Models
{
    public class Message : Base
    {
        private const int MESSAGES_PER_PAGE = 20;

        public Message(Api api)
        {
            Api = api;
        }

        /// <summary>
        /// View many email messages with a single API call.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        public MessageSelectList List(int page, params int[] ids)
        {
            var request = Api.AcUrl + "message_list";

            string postData = "ids=" + HttpHelper.IdsStr(ids);
            postData += "&page=" + page;
            return SendRequest<MessageSelectList>(request, postData);
        }

        /// <summary>
        /// View all email messages with a single API call.
        /// </summary>
        /// <returns></returns>
        public MessageSelectList List()
        {
            MessageSelectList result = null;
            int page = 0;
            while(true)
            {
                var r = List(page);

                page++;

                if (result == null)
                {
                    result = r;
                }
                else
                {
                    result.Messages.AddRange(r.Messages);
                }

                if (r.ResultCode == 0 || r.Messages.Count < MESSAGES_PER_PAGE) return result;
            }
        }


        /// <summary>
        /// Add a new email message to the system.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public string Add(MessageAddOptions options)
        {
            var request = Api.AcUrl + "message_add";

            string postData = "format=" + options.format;
            postData += "&subject=" + options.subject;
            postData += "&fromemail=" + options.fromemail;
            postData += "&fromname=" + options.fromname;
            postData += "&reply2=" + options.reply2;
            postData += "&priority=" + (int)options.priority;
            postData += "&charset=" + options.charset;
            postData += "&encoding=" + options.encoding;
            postData += "&html=" + options.html;
            postData += "&htmlconstructor=" + options.htmlconstructor;
            postData += "&htmlfetch=" + options.htmlfetch;
            postData += "&htmlfetchwhen=" + options.htmlfetchwhen;
            postData += "&textconstructor=" + options.textconstructor;
            postData += "&text=" + options.text;
            postData += "&textfetch=" + options.textfetch;
            postData += "&textfetchwhen=" + options.textfetchwhen;
            postData += HttpHelper.FormatValues("p", options.ListDictionary);
            return WriteStream(request, postData);
        }

        /// <summary>
        /// View a email message data, such as internal name, subject, content, visibility, etc.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MessageSelectResult View(int id)
        {
            var request = Api.AcUrl + "message_view";

            string postData = "id=" + id;
            return SendRequest<MessageSelectResult>(request, postData);
        }

        /// <summary>
        /// View a email message data, such as internal name, subject, content, visibility, etc.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<MessageSelectResult> View(int[] id)
        {
            return id.Select(View).ToList();
        }
    }
}