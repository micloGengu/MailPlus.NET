// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class CampaignStopRequest
    {
        /// <summary>
        /// Initializes a new instance of the CampaignStopRequest class.
        /// </summary>
        public CampaignStopRequest() { }

        /// <summary>
        /// Initializes a new instance of the CampaignStopRequest class.
        /// </summary>
        /// <param name="externalContactId">Specified contact reference by
        /// external system</param>
        public CampaignStopRequest(string externalContactId)
        {
            ExternalContactId = externalContactId;
        }

        /// <summary>
        /// Gets or sets specified contact reference by external system
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "externalContactId")]
        public string ExternalContactId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExternalContactId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ExternalContactId");
            }
        }
    }
}
