// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class MailingRecipient
    {
        /// <summary>
        /// Initializes a new instance of the MailingRecipient class.
        /// </summary>
        public MailingRecipient() { }

        /// <summary>
        /// Initializes a new instance of the MailingRecipient class.
        /// </summary>
        public MailingRecipient(ContactIdentifier contactIdentifier)
        {
            ContactIdentifier = contactIdentifier;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "contactIdentifier")]
        public ContactIdentifier ContactIdentifier { get; set; }

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
