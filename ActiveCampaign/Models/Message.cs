using ActiveCampaign.Responses;
using ActiveCampaign.Struct;

namespace ActiveCampaign.Models
{
    public class Message : Base
    {
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
        public string List(int page, params int[] ids)
        {
            var request = Api.AcUrl + "message_list";

            string postData = "ids=" + HttpHelper.IdsStr(ids);
            postData += "&page=" + page;
            return WriteStream(request, postData);
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
    }
}