using System.Collections.Generic;

namespace ActiveCampaign.Struct
{
    public class MessageAddOptions
    {
        public MessageAddOptions()
        {
            charset = "utf-8";
            encoding = "quoted-printable";
            htmlconstructor = HtmlConstructorOptions.upload;
            format = CampaignSendTypes.html;
            ListDictionary = new Dictionary<int, int>();
        }

        public CampaignSendTypes format { get; set; }

        public string subject { get; set; }

        public string fromemail { get; set; }

        public string fromname { get; set; }

        public string reply2 { get; set; }

        public Priority priority { get; set; }

        public string charset { get; set; }

        public string encoding { get; set; }

        public HtmlConstructorOptions htmlconstructor { get; set; }

        public string htmlfetch { get; set; }

        public string htmlfetchwhen { get; set; }

        public string textconstructor { get; set; }

        public string text { get; set; }

        public string textfetch { get; set; }

        public string textfetchwhen { get; set; }

        public Dictionary<int, int> ListDictionary { get; set; }
    }

    public enum HtmlConstructorOptions
    {
        editor, external, upload
    }

    public enum Priority
    {
        high = 1, medium = 3, low =5
    }
}