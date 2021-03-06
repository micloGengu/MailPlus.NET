// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class CampaignMailingOpen
    {
        /// <summary>
        /// Initializes a new instance of the CampaignMailingOpen class.
        /// </summary>
        public CampaignMailingOpen() { }

        /// <summary>
        /// Initializes a new instance of the CampaignMailingOpen class.
        /// </summary>
        /// <param name="openDate">Date & time the open occurred</param>
        public CampaignMailingOpen(int campaignSubscriptionId, ContactIdentifier contactIdentifier, System.DateTime openDate)
        {
            CampaignSubscriptionId = campaignSubscriptionId;
            ContactIdentifier = contactIdentifier;
            OpenDate = openDate;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "campaignSubscriptionId")]
        public int CampaignSubscriptionId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "contactIdentifier")]
        public ContactIdentifier ContactIdentifier { get; set; }

        /// <summary>
        /// Gets or sets date &amp; time the open occurred
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "openDate")]
        public System.DateTime OpenDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContactIdentifier == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ContactIdentifier");
            }
            if (this.ContactIdentifier != null)
            {
                this.ContactIdentifier.Validate();
            }
        }
    }
}
