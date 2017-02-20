// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class FormElementResult
    {
        /// <summary>
        /// Initializes a new instance of the FormElementResult class.
        /// </summary>
        public FormElementResult() { }

        /// <summary>
        /// Initializes a new instance of the FormElementResult class.
        /// </summary>
        public FormElementResult(string description, int fieldId, int rank, System.Collections.Generic.IList<string> answer = default(System.Collections.Generic.IList<string>))
        {
            Answer = answer;
            Description = description;
            FieldId = fieldId;
            Rank = rank;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "answer")]
        public System.Collections.Generic.IList<string> Answer { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fieldId")]
        public int FieldId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rank")]
        public int Rank { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Description == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Description");
            }
        }
    }
}
