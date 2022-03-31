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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace XRoad.Sdk.Model;

/// <summary>
/// Ocsp responder diagnostics
/// </summary>
[DataContract(Name = "OcspResponderDiagnostics")]
public class OcspResponderDiagnostics : IEquatable<OcspResponderDiagnostics>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OcspResponderDiagnostics" /> class.
    /// </summary>
    [JsonConstructor]
    public OcspResponderDiagnostics()
    {
    }

    /// <summary>
    /// CA distinguished name
    /// </summary>
    /// <value>CA distinguished name</value>
    [DataMember(Name = "distinguished_name", IsRequired = true, EmitDefaultValue = false)]
    public string DistinguishedName { get; }

    /// <summary>
    /// Returns false as DistinguishedName should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeDistinguishedName()
    {
        return false;
    }

    /// <summary>
    /// Gets or Sets OcspResponders
    /// </summary>
    [DataMember(Name = "ocsp_responders", IsRequired = true, EmitDefaultValue = false)]
    public List<OcspResponder> OcspResponders { get; }

    /// <summary>
    /// Returns false as OcspResponders should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeOcspResponders()
    {
        return false;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OcspResponderDiagnostics {\n");
        sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
        sb.Append("  OcspResponders: ").Append(OcspResponders).Append("\n");
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
        return Equals(input as OcspResponderDiagnostics);
    }

    /// <summary>
    /// Returns true if OcspResponderDiagnostics instances are equal
    /// </summary>
    /// <param name="input">Instance of OcspResponderDiagnostics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OcspResponderDiagnostics input)
    {
        if (input == null) return false;
        return
            (
                DistinguishedName == input.DistinguishedName ||
                (DistinguishedName != null &&
                 DistinguishedName.Equals(input.DistinguishedName))
            ) &&
            (
                OcspResponders == input.OcspResponders ||
                (OcspResponders != null &&
                 input.OcspResponders != null &&
                 OcspResponders.SequenceEqual(input.OcspResponders))
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
            var hashCode = 41;
            if (DistinguishedName != null) hashCode = hashCode * 59 + DistinguishedName.GetHashCode();
            if (OcspResponders != null) hashCode = hashCode * 59 + OcspResponders.GetHashCode();
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
        // DistinguishedName (string) maxLength
        if (DistinguishedName is {Length: > 255})
            yield return new ValidationResult("Invalid value for DistinguishedName, length must be less than 255.",
                new[] {"DistinguishedName"});

        // DistinguishedName (string) minLength
        if (DistinguishedName is {Length: < 1})
            yield return new ValidationResult("Invalid value for DistinguishedName, length must be greater than 1.",
                new[] {"DistinguishedName"});
    }
}