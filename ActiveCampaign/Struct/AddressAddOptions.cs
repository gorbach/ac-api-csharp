using System.Collections.Generic;

namespace ActiveCampaign.Struct
{
    public class AddressAddOptions
    {
        /// <summary>
        /// Physical mailing address
        /// </summary>
        public string addr_1;

        /// <summary>
        /// Physical mailing address
        /// </summary>
        public string addr_2;

        /// <summary>
        /// Physical mailing address city
        /// </summary>
        public string city;

        /// <summary>
        /// Physical mailing address state
        /// </summary>
        public string state;

        /// <summary>
        /// Physical mailing address zip
        /// </summary>
        public string zip;

        /// <summary>
        /// Physical mailing address country
        /// </summary>
        public string country;

        /// <summary>
        /// Permissions given to all groups
        /// </summary>
        public bool allgroup;

        /// <summary>
        /// Assign to lists
        /// </summary>
        public Dictionary<int, int> list;

        /// <summary>
        /// Assign to group
        /// </summary>
        public Dictionary<int, int> group;

        /// <summary>
        /// Name of the company
        /// </summary>
        public string CompanyName { get; set; }
    }
}