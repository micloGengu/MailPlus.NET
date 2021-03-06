// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class ContactBounce
    {
        /// <summary>
        /// Initializes a new instance of the ContactBounce class.
        /// </summary>
        public ContactBounce() { }

        /// <summary>
        /// Initializes a new instance of the ContactBounce class.
        /// </summary>
        /// <param name="date">Date & time the bounce occurred</param>
        /// <param name="type">Possible values include: 'HARDBOUNCE',
        /// 'SOFTBOUNCE'</param>
        /// <param name="encryptedActId">encryptedMailingId (Use '/mailing/*'
        /// to request additional data)</param>
        public ContactBounce(Contact contact, System.DateTime date, string type, string encryptedActId = default(string))
        {
            Contact = contact;
            Date = date;
            EncryptedActId = encryptedActId;
            Type = type;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "contact")]
        public Contact Contact { get; set; }

        /// <summary>
        /// Gets or sets date &amp; time the bounce occurred
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "date")]
        public System.DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets encryptedMailingId (Use '/mailing/*' to request
        /// additional data)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptedActId")]
        public string EncryptedActId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'HARDBOUNCE', 'SOFTBOUNCE'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Contact == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Contact");
            }
            if (Type == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Type");
            }
            if (this.Contact != null)
            {
                this.Contact.Validate();
            }
        }
    }
}
