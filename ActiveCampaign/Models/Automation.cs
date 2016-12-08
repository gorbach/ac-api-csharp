using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveCampaign.Models
{
    public class Automation : Base
    {
        public Automation(Api api)
        {
            Api = api;
        }

        public string ContactAdd(int contactId, string contactEmail, List<int> automationList)
        {
            throw new NotImplementedException();
        }

        public string ContactRemove(int contactId, string contactEmail, List<int> automationList)
        {
            throw new NotImplementedException();
        }

        public string ContactView(int contactId, string contactEmail)
        {
            throw new NotImplementedException();
        }

        public string ContactList(Dictionary<string, string> paramsDictionary)
        {
            throw new NotImplementedException();
        }

        public string List(Dictionary<string, string> paramsDictionary)
        {
            throw new NotImplementedException();
        }
    }
}