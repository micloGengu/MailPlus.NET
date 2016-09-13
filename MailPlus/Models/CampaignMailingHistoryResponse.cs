// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class CampaignMailingHistoryResponse
    {
        /// <summary>
        /// Initializes a new instance of the CampaignMailingHistoryResponse
        /// class.
        /// </summary>
        public CampaignMailingHistoryResponse() { }

        /// <summary>
        /// Initializes a new instance of the CampaignMailingHistoryResponse
        /// class.
        /// </summary>
        public CampaignMailingHistoryResponse(IList<CampaignMailingHistory> campaignMailingHistories = default(IList<CampaignMailingHistory>), Paging paging = default(Paging))
        {
            CampaignMailingHistories = campaignMailingHistories;
            Paging = paging;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignMailingHistories")]
        public IList<CampaignMailingHistory> CampaignMailingHistories { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paging")]
        public Paging Paging { get; set; }

    }
}