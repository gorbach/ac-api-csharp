using System.Collections.Generic;

namespace ActiveCampaign.Struct
{
    public class CampaignListOptions
    {
        public int[] Ids { get; set; }

        public Dictionary<string, string> Filters { get; set; }

        public bool full { get; set; }

        /// <summary>
        /// Field to sort on (possible values: id, cdate).
        /// </summary>
        public CampaignSortOptions sort { get; set; }

        /// <summary>
        /// Direction of sort (possible values: ASC or DESC).
        /// </summary>
        public SortDirections sort_direction { get; set; }

        /// <summary>
        /// Pagination: results are limited to 10 per page, so specify what page to view.
        /// </summary>
        public int page { get; set; }
    }
}