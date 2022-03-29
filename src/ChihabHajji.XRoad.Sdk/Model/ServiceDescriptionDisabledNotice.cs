/*
 * X-Road Security Server Admin API
 *
 * X-Road Security Server Admin API. Note that the error metadata responses described in some endpoints are subjects to change and may be updated in upcoming versions.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: info@niis.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ChihabHajji.XRoad.Sdk.Client.OpenAPIDateConverter;

namespace ChihabHajji.XRoad.Sdk.Model
{
    /// <summary>
    /// ServiceDescriptionDisabledNotice
    /// </summary>
    [DataContract(Name = "ServiceDescriptionDisabledNotice")]
    public partial class ServiceDescriptionDisabledNotice : IEquatable<ServiceDescriptionDisabledNotice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDescriptionDisabledNotice" /> class.
        /// </summary>
        /// <param name="disabledNotice">disabled service notice.</param>
        public ServiceDescriptionDisabledNotice(string disabledNotice = default(string))
        {
            this.DisabledNotice = disabledNotice;
        }

        /// <summary>
        /// disabled service notice
        /// </summary>
        /// <value>disabled service notice</value>
        [DataMember(Name = "disabled_notice", EmitDefaultValue = false)]
        public string DisabledNotice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceDescriptionDisabledNotice {\n");
            sb.Append("  DisabledNotice: ").Append(DisabledNotice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceDescriptionDisabledNotice);
        }

        /// <summary>
        /// Returns true if ServiceDescriptionDisabledNotice instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceDescriptionDisabledNotice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceDescriptionDisabledNotice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisabledNotice == input.DisabledNotice ||
                    (this.DisabledNotice != null &&
                    this.DisabledNotice.Equals(input.DisabledNotice))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DisabledNotice != null)
                {
                    hashCode = (hashCode * 59) + this.DisabledNotice.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // DisabledNotice (string) maxLength
            if (this.DisabledNotice != null && this.DisabledNotice.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisabledNotice, length must be less than 255.", new [] { "DisabledNotice" });
            }

            // DisabledNotice (string) minLength
            if (this.DisabledNotice != null && this.DisabledNotice.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisabledNotice, length must be greater than 0.", new [] { "DisabledNotice" });
            }

            yield break;
        }
    }

}