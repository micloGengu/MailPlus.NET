// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class ContactIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the ContactIdentifier class.
        /// </summary>
        public ContactIdentifier() { }

        /// <summary>
        /// Initializes a new instance of the ContactIdentifier class.
        /// </summary>
        /// <param name="encryptedId">Contact reference generated by
        /// MailPlus</param>
        /// <param name="externalId">Specified contact reference by external
        /// system</param>
        public ContactIdentifier(string encryptedId, string externalId = default(string))
        {
            EncryptedId = encryptedId;
            ExternalId = externalId;
        }

        /// <summary>
        /// Gets or sets contact reference generated by MailPlus
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptedId")]
        public string EncryptedId { get; set; }

        /// <summary>
        /// Gets or sets specified contact reference by external system
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EncryptedId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "EncryptedId");
            }
        }
    }
}
