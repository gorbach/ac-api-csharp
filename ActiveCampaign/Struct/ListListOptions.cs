using System.Collections.Generic;

namespace ActiveCampaign.Struct
{
    public class ListListOptions
    {
        public ListListOptions()
        {
            Filters = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Filters { get; set; }
        public bool Full { get; set; }
        public bool GlobalFields { get; set; }

        public int[] Ids { get; set; }
    }
}