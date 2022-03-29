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
    /// key-value pair of strings
    /// </summary>
    [DataContract(Name = "KeyValuePair")]
    public partial class KeyValuePair : IEquatable<KeyValuePair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValuePair" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KeyValuePair() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValuePair" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        /// <param name="value">value (required).</param>
        public KeyValuePair(string key = default(string), string value = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null) {
                throw new ArgumentNullException("key is a required property for KeyValuePair and cannot be null");
            }
            this.Key = key;
            // to ensure "value" is required (not null)
            if (value == null) {
                throw new ArgumentNullException("value is a required property for KeyValuePair and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// key
        /// </summary>
        /// <value>key</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// value
        /// </summary>
        /// <value>value</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KeyValuePair {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as KeyValuePair);
        }

        /// <summary>
        /// Returns true if KeyValuePair instances are equal
        /// </summary>
        /// <param name="input">Instance of KeyValuePair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyValuePair input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
            yield break;
        }
    }

}
