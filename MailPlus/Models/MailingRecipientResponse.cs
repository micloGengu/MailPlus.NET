// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class MailingRecipientResponse
    {
        /// <summary>
        /// Initializes a new instance of the MailingRecipientResponse class.
        /// </summary>
        public MailingRecipientResponse() { }

        /// <summary>
        /// Initializes a new instance of the MailingRecipientResponse class.
        /// </summary>
        public MailingRecipientResponse(Paging paging = default(Paging), System.Collections.Generic.IList<MailingRecipient> recipients = default(System.Collections.Generic.IList<MailingRecipient>))
        {
            Paging = paging;
            Recipients = recipients;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "paging")]
        public Paging Paging { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recipients")]
        public System.Collections.Generic.IList<MailingRecipient> Recipients { get; set; }

    }
}
