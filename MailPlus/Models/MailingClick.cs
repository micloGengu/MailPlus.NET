// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class MailingClick
    {
        /// <summary>
        /// Initializes a new instance of the MailingClick class.
        /// </summary>
        public MailingClick() { }

        /// <summary>
        /// Initializes a new instance of the MailingClick class.
        /// </summary>
        /// <param name="clickDate">Date & time the click occurred</param>
        public MailingClick(System.DateTime clickDate, ContactIdentifier contactIdentifier, int linkId)
        {
            ClickDate = clickDate;
            ContactIdentifier = contactIdentifier;
            LinkId = linkId;
        }

        /// <summary>
        /// Gets or sets date &amp; time the click occurred
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clickDate")]
        public System.DateTime ClickDate { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "contactIdentifier")]
        public ContactIdentifier ContactIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "linkId")]
        public int LinkId { get; set; }

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
