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
    /// timestamping services
    /// </summary>
    [DataContract(Name = "TimestampingService")]
    public partial class TimestampingService : IEquatable<TimestampingService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampingService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimestampingService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimestampingService" /> class.
        /// </summary>
        /// <param name="name">name of the time stamping service (required).</param>
        /// <param name="url">url of the time stamping service (required).</param>
        public TimestampingService(string name = default(string), string url = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for TimestampingService and cannot be null");
            }
            this.Name = name;
            // to ensure "url" is required (not null)
            if (url == null) {
                throw new ArgumentNullException("url is a required property for TimestampingService and cannot be null");
            }
            this.Url = url;
        }

        /// <summary>
        /// name of the time stamping service
        /// </summary>
        /// <value>name of the time stamping service</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// url of the time stamping service
        /// </summary>
        /// <value>url of the time stamping service</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimestampingService {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as TimestampingService);
        }

        /// <summary>
        /// Returns true if TimestampingService instances are equal
        /// </summary>
        /// <param name="input">Instance of TimestampingService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimestampingService input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Url (string) maxLength
            if (this.Url != null && this.Url.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be less than 255.", new [] { "Url" });
            }

            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            yield break;
        }
    }

}