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
/// object returned in error cases
/// </summary>
[DataContract(Name = "ErrorInfo")]
public class ErrorInfo : IEquatable<ErrorInfo>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorInfo" /> class.
    /// </summary>
    [JsonConstructor]
    protected ErrorInfo()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorInfo" /> class.
    /// </summary>
    /// <param name="status">http status code (required).</param>
    /// <param name="error">error.</param>
    /// <param name="warnings">warnings that could be ignored.</param>
    public ErrorInfo(int status = default, CodeWithDetails error = default, List<CodeWithDetails> warnings = default)
    {
        Status = status;
        Error = error;
        Warnings = warnings;
    }

    /// <summary>
    /// http status code
    /// </summary>
    /// <value>http status code</value>
    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
    public int Status { get; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public CodeWithDetails Error { get; }

    /// <summary>
    /// warnings that could be ignored
    /// </summary>
    /// <value>warnings that could be ignored</value>
    [DataMember(Name = "warnings", EmitDefaultValue = false)]
    public List<CodeWithDetails> Warnings { get; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ErrorInfo {\n");
        sb.Append("  Status: ").Append(Status).Append('\n');
        sb.Append("  Error: ").Append(Error).Append('\n');
        sb.Append("  Warnings: ").Append(Warnings).Append('\n');
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
        return Equals(input as ErrorInfo);
    }

    /// <summary>
    /// Returns true if ErrorInfo instances are equal
    /// </summary>
    /// <param name="input">Instance of ErrorInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ErrorInfo input)
    {
        if (input == null) return false;
        return
            (
                Status == input.Status ||
                Status.Equals(input.Status)
            ) &&
            (
                Error.Equals(input.Error) ||
                (Error != null &&
                 Error.Equals(input.Error))
            ) &&
            (
                Warnings == input.Warnings ||
                (Warnings != null &&
                 input.Warnings != null &&
                 Warnings.SequenceEqual(input.Warnings))
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
            hashCode = hashCode * 59 + Status.GetHashCode();
            if (Error != null) hashCode = hashCode * 59 + Error.GetHashCode();
            if (Warnings != null) hashCode = hashCode * 59 + Warnings.GetHashCode();
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
        yield break;
    }
}