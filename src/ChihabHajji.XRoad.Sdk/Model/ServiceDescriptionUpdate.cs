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
    /// request object for updating a service description url or service code
    /// </summary>
    [DataContract(Name = "ServiceDescriptionUpdate")]
    public partial class ServiceDescriptionUpdate : IEquatable<ServiceDescriptionUpdate>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public ServiceType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDescriptionUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceDescriptionUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDescriptionUpdate" /> class.
        /// </summary>
        /// <param name="url">path for the service description file (required).</param>
        /// <param name="restServiceCode">service code for REST service.</param>
        /// <param name="newRestServiceCode">new service code for REST service.</param>
        /// <param name="ignoreWarnings">if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail (default to false).</param>
        /// <param name="type">type (required).</param>
        public ServiceDescriptionUpdate(string url = default(string), string restServiceCode = default(string), string newRestServiceCode = default(string), bool ignoreWarnings = false, ServiceType type = default(ServiceType))
        {
            // to ensure "url" is required (not null)
            if (url == null) {
                throw new ArgumentNullException("url is a required property for ServiceDescriptionUpdate and cannot be null");
            }
            this.Url = url;
            this.Type = type;
            this.RestServiceCode = restServiceCode;
            this.NewRestServiceCode = newRestServiceCode;
            this.IgnoreWarnings = ignoreWarnings;
        }

        /// <summary>
        /// path for the service description file
        /// </summary>
        /// <value>path for the service description file</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// service code for REST service
        /// </summary>
        /// <value>service code for REST service</value>
        [DataMember(Name = "rest_service_code", EmitDefaultValue = false)]
        public string RestServiceCode { get; set; }

        /// <summary>
        /// new service code for REST service
        /// </summary>
        /// <value>new service code for REST service</value>
        [DataMember(Name = "new_rest_service_code", EmitDefaultValue = false)]
        public string NewRestServiceCode { get; set; }

        /// <summary>
        /// if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail
        /// </summary>
        /// <value>if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail</value>
        [DataMember(Name = "ignore_warnings", EmitDefaultValue = true)]
        public bool IgnoreWarnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceDescriptionUpdate {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  RestServiceCode: ").Append(RestServiceCode).Append("\n");
            sb.Append("  NewRestServiceCode: ").Append(NewRestServiceCode).Append("\n");
            sb.Append("  IgnoreWarnings: ").Append(IgnoreWarnings).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ServiceDescriptionUpdate);
        }

        /// <summary>
        /// Returns true if ServiceDescriptionUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceDescriptionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceDescriptionUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.RestServiceCode == input.RestServiceCode ||
                    (this.RestServiceCode != null &&
                    this.RestServiceCode.Equals(input.RestServiceCode))
                ) && 
                (
                    this.NewRestServiceCode == input.NewRestServiceCode ||
                    (this.NewRestServiceCode != null &&
                    this.NewRestServiceCode.Equals(input.NewRestServiceCode))
                ) && 
                (
                    this.IgnoreWarnings == input.IgnoreWarnings ||
                    this.IgnoreWarnings.Equals(input.IgnoreWarnings)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.RestServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.RestServiceCode.GetHashCode();
                }
                if (this.NewRestServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.NewRestServiceCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IgnoreWarnings.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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

            // RestServiceCode (string) maxLength
            if (this.RestServiceCode != null && this.RestServiceCode.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RestServiceCode, length must be less than 255.", new [] { "RestServiceCode" });
            }

            // RestServiceCode (string) minLength
            if (this.RestServiceCode != null && this.RestServiceCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RestServiceCode, length must be greater than 1.", new [] { "RestServiceCode" });
            }

            // NewRestServiceCode (string) maxLength
            if (this.NewRestServiceCode != null && this.NewRestServiceCode.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewRestServiceCode, length must be less than 255.", new [] { "NewRestServiceCode" });
            }

            // NewRestServiceCode (string) minLength
            if (this.NewRestServiceCode != null && this.NewRestServiceCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewRestServiceCode, length must be greater than 1.", new [] { "NewRestServiceCode" });
            }

            yield break;
        }
    }

}
