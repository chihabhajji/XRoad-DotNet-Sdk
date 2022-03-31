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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace XRoad.Sdk.Model;

/// <summary>
/// KeyLabel
/// </summary>
[DataContract(Name = "KeyLabel")]
public class KeyLabel : IEquatable<KeyLabel>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KeyLabel" /> class.
    /// </summary>
    /// <param name="label">label for the new key.</param>
    public KeyLabel(string label = default)
    {
        Label = label;
    }

    /// <summary>
    /// label for the new key
    /// </summary>
    /// <value>label for the new key</value>
    [DataMember(Name = "label", EmitDefaultValue = false)]
    public string Label { get; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KeyLabel {\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
        return Equals(input as KeyLabel);
    }

    /// <summary>
    /// Returns true if KeyLabel instances are equal
    /// </summary>
    /// <param name="input">Instance of KeyLabel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KeyLabel input)
    {
        if (input == null) return false;
        return
            Label == input.Label ||
            (Label != null &&
             Label.Equals(input.Label));
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            var hashCode = 41;
            if (Label != null) hashCode = hashCode * 59 + Label.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Label (string) maxLength
        if (Label is {Length: > 255})
            yield return new ValidationResult("Invalid value for Label, length must be less than 255.",
                new[] {"Label"});

        // Label (string) minLength
        if (Label is {Length: < 1})
            yield return new ValidationResult("Invalid value for Label, length must be greater than 1.",
                new[] {"Label"});
    }
}