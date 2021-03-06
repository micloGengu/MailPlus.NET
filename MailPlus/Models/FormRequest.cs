// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System.Linq;

    public partial class FormRequest
    {
        /// <summary>
        /// Initializes a new instance of the FormRequest class.
        /// </summary>
        public FormRequest() { }

        /// <summary>
        /// Initializes a new instance of the FormRequest class.
        /// </summary>
        /// <param name="postUrl">Form action URL</param>
        /// <param name="encId">Form reference generated by MailPlus</param>
        /// <param name="outputFormat">Default value: HTML4STRICT. Possible
        /// values include: 'HTML4STRICT', 'XHTML1STRICT'</param>
        /// <param name="outputMode">Default value: TABLES. Possible values
        /// include: 'TABLES', 'DIV'</param>
        /// <param name="prefilledValues">Given values will be prefilled in
        /// the HTML output</param>
        public FormRequest(string postUrl, string encId = default(string), string extraParams = default(string), string outputFormat = default(string), string outputMode = default(string), System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> prefilledValues = default(System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>>))
        {
            EncId = encId;
            ExtraParams = extraParams;
            OutputFormat = outputFormat;
            OutputMode = outputMode;
            PostUrl = postUrl;
            PrefilledValues = prefilledValues;
        }

        /// <summary>
        /// Gets or sets form reference generated by MailPlus
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encId")]
        public string EncId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "extraParams")]
        public string ExtraParams { get; set; }

        /// <summary>
        /// Gets or sets default value: HTML4STRICT. Possible values include:
        /// 'HTML4STRICT', 'XHTML1STRICT'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "outputFormat")]
        public string OutputFormat { get; set; }

        /// <summary>
        /// Gets or sets default value: TABLES. Possible values include:
        /// 'TABLES', 'DIV'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "outputMode")]
        public string OutputMode { get; set; }

        /// <summary>
        /// Gets or sets form action URL
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "postUrl")]
        public string PostUrl { get; set; }

        /// <summary>
        /// Gets or sets given values will be prefilled in the HTML output
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "prefilledValues")]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> PrefilledValues { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PostUrl == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PostUrl");
            }
        }
    }
}
