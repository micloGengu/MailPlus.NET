// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class Order
    {
        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        public Order() { }

        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        /// <param name="date">Date & time the order was placed</param>
        /// <param name="externalContactId">Specified contact reference by
        /// external system</param>
        /// <param name="externalId">Specified order reference by external
        /// system</param>
        /// <param name="externalProductIds">Products part of the order (Use
        /// '/product/*' to request or post additional data)</param>
        /// <param name="value">Total order value in cents</param>
        public Order(string date, string externalContactId, string externalId, System.Collections.Generic.IList<string> externalProductIds, string value)
        {
            Date = date;
            ExternalContactId = externalContactId;
            ExternalId = externalId;
            ExternalProductIds = externalProductIds;
            Value = value;
        }

        /// <summary>
        /// Gets or sets date &amp; time the order was placed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets specified contact reference by external system
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "externalContactId")]
        public string ExternalContactId { get; set; }

        /// <summary>
        /// Gets or sets specified order reference by external system
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets products part of the order (Use '/product/*' to
        /// request or post additional data)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "externalProductIds")]
        public System.Collections.Generic.IList<string> ExternalProductIds { get; set; }

        /// <summary>
        /// Gets or sets total order value in cents
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Date == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Date");
            }
            if (ExternalContactId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ExternalContactId");
            }
            if (ExternalId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ExternalId");
            }
            if (ExternalProductIds == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ExternalProductIds");
            }
            if (Value == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
