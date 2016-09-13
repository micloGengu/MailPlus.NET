// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MailPlus.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class FormResult
    {
        /// <summary>
        /// Initializes a new instance of the FormResult class.
        /// </summary>
        public FormResult() { }

        /// <summary>
        /// Initializes a new instance of the FormResult class.
        /// </summary>
        public FormResult(bool completed, int formResultId, DateTime submittedAt, bool testResult, IList<FormElementResult> answers = default(IList<FormElementResult>))
        {
            Answers = answers;
            Completed = completed;
            FormResultId = formResultId;
            SubmittedAt = submittedAt;
            TestResult = testResult;
        }

        /// <summary>
        /// All form questions and answers if available
        /// </summary>
        [JsonProperty(PropertyName = "answers")]
        public IList<FormElementResult> Answers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completed")]
        public bool Completed { get; set; }

        /// <summary>
        /// (Use '/form/result*' to request additional data)
        /// </summary>
        [JsonProperty(PropertyName = "formResultId")]
        public int FormResultId { get; set; }

        /// <summary>
        /// Date &amp; time the form was submitted
        /// </summary>
        [JsonProperty(PropertyName = "submittedAt")]
        public DateTime SubmittedAt { get; set; }

        /// <summary>
        /// Test results only occur when the formState is not final
        /// </summary>
        [JsonProperty(PropertyName = "testResult")]
        public bool TestResult { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Answers != null)
            {
                foreach (var element in this.Answers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}