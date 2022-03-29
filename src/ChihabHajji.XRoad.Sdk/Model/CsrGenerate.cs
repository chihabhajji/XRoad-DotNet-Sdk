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
    /// request to generate a CSR
    /// </summary>
    [DataContract(Name = "CsrGenerate")]
    public partial class CsrGenerate : IEquatable<CsrGenerate>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets KeyUsageType
        /// </summary>
        [DataMember(Name = "key_usage_type", IsRequired = true, EmitDefaultValue = false)]
        public KeyUsageType KeyUsageType { get; set; }

        /// <summary>
        /// Gets or Sets CsrFormat
        /// </summary>
        [DataMember(Name = "csr_format", IsRequired = true, EmitDefaultValue = false)]
        public CsrFormat CsrFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsrGenerate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CsrGenerate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CsrGenerate" /> class.
        /// </summary>
        /// <param name="keyUsageType">keyUsageType (required).</param>
        /// <param name="caName">common name of the CA (required).</param>
        /// <param name="csrFormat">csrFormat (required).</param>
        /// <param name="memberId">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;.</param>
        /// <param name="subjectFieldValues">user-provided values for subject DN parameters (required).</param>
        public CsrGenerate(KeyUsageType keyUsageType = default(KeyUsageType), string caName = default(string), CsrFormat csrFormat = default(CsrFormat), string memberId = default(string), Dictionary<string, string> subjectFieldValues = default(Dictionary<string, string>))
        {
            this.KeyUsageType = keyUsageType;
            // to ensure "caName" is required (not null)
            if (caName == null) {
                throw new ArgumentNullException("caName is a required property for CsrGenerate and cannot be null");
            }
            this.CaName = caName;
            this.CsrFormat = csrFormat;
            // to ensure "subjectFieldValues" is required (not null)
            if (subjectFieldValues == null) {
                throw new ArgumentNullException("subjectFieldValues is a required property for CsrGenerate and cannot be null");
            }
            this.SubjectFieldValues = subjectFieldValues;
            this.MemberId = memberId;
        }

        /// <summary>
        /// common name of the CA
        /// </summary>
        /// <value>common name of the CA</value>
        [DataMember(Name = "ca_name", IsRequired = true, EmitDefaultValue = false)]
        public string CaName { get; set; }

        /// <summary>
        /// member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;
        /// </summary>
        /// <value>member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;</value>
        [DataMember(Name = "member_id", EmitDefaultValue = false)]
        public string MemberId { get; set; }

        /// <summary>
        /// user-provided values for subject DN parameters
        /// </summary>
        /// <value>user-provided values for subject DN parameters</value>
        [DataMember(Name = "subject_field_values", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> SubjectFieldValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CsrGenerate {\n");
            sb.Append("  KeyUsageType: ").Append(KeyUsageType).Append("\n");
            sb.Append("  CaName: ").Append(CaName).Append("\n");
            sb.Append("  CsrFormat: ").Append(CsrFormat).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  SubjectFieldValues: ").Append(SubjectFieldValues).Append("\n");
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
            return this.Equals(input as CsrGenerate);
        }

        /// <summary>
        /// Returns true if CsrGenerate instances are equal
        /// </summary>
        /// <param name="input">Instance of CsrGenerate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsrGenerate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeyUsageType == input.KeyUsageType ||
                    this.KeyUsageType.Equals(input.KeyUsageType)
                ) && 
                (
                    this.CaName == input.CaName ||
                    (this.CaName != null &&
                    this.CaName.Equals(input.CaName))
                ) && 
                (
                    this.CsrFormat == input.CsrFormat ||
                    this.CsrFormat.Equals(input.CsrFormat)
                ) && 
                (
                    this.MemberId == input.MemberId ||
                    (this.MemberId != null &&
                    this.MemberId.Equals(input.MemberId))
                ) && 
                (
                    this.SubjectFieldValues == input.SubjectFieldValues ||
                    this.SubjectFieldValues != null &&
                    input.SubjectFieldValues != null &&
                    this.SubjectFieldValues.SequenceEqual(input.SubjectFieldValues)
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
                hashCode = (hashCode * 59) + this.KeyUsageType.GetHashCode();
                if (this.CaName != null)
                {
                    hashCode = (hashCode * 59) + this.CaName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CsrFormat.GetHashCode();
                if (this.MemberId != null)
                {
                    hashCode = (hashCode * 59) + this.MemberId.GetHashCode();
                }
                if (this.SubjectFieldValues != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectFieldValues.GetHashCode();
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
            // CaName (string) maxLength
            if (this.CaName != null && this.CaName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CaName, length must be less than 255.", new [] { "CaName" });
            }

            // CaName (string) minLength
            if (this.CaName != null && this.CaName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CaName, length must be greater than 1.", new [] { "CaName" });
            }

            // MemberId (string) maxLength
            if (this.MemberId != null && this.MemberId.Length > 767)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MemberId, length must be less than 767.", new [] { "MemberId" });
            }

            // MemberId (string) minLength
            if (this.MemberId != null && this.MemberId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MemberId, length must be greater than 1.", new [] { "MemberId" });
            }

            yield break;
        }
    }

}
