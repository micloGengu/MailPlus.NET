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

    public partial class MailingContactClickResponse
    {
        /// <summary>
        /// Initializes a new instance of the MailingContactClickResponse
        /// class.
        /// </summary>
        public MailingContactClickResponse() { }

        /// <summary>
        /// Initializes a new instance of the MailingContactClickResponse
        /// class.
        /// </summary>
        public MailingContactClickResponse(IList<MailingContactClick> clicks = default(IList<MailingContactClick>), Paging paging = default(Paging))
        {
            Clicks = clicks;
            Paging = paging;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clicks")]
        public IList<MailingContactClick> Clicks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paging")]
        public Paging Paging { get; set; }

    }
}