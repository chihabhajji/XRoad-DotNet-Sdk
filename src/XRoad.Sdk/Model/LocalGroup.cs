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
/// group
/// </summary>
[DataContract(Name = "LocalGroup")]
public class LocalGroup : IEquatable<LocalGroup>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LocalGroup" /> class.
    /// </summary>
    [JsonConstructor]
    protected LocalGroup()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LocalGroup" /> class.
    /// </summary>
    /// <param name="code">group code (required).</param>
    /// <param name="description">group description (required).</param>
    /// <param name="memberCount">member count.</param>
    /// <param name="updatedAt">last time updated.</param>
    /// <param name="members">group members.</param>
    public LocalGroup(string code = default, string description = default, int memberCount = default,
        DateTime updatedAt = default, List<GroupMember> members = default)
    {
        // to ensure "code" is required (not null)
        Code = code ?? throw new ArgumentNullException(nameof(code),"code is a required property for LocalGroup and cannot be null");
        // to ensure "description" is required (not null)
        Description = description ?? throw new ArgumentNullException(nameof(description),"description is a required property for LocalGroup and cannot be null");
        MemberCount = memberCount;
        UpdatedAt = updatedAt;
        Members = members;
    }

    /// <summary>
    /// unique identifier
    /// </summary>
    /// <value>unique identifier</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; }

    /// <summary>
    /// Returns false as Id should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeId()
    {
        return false;
    }

    /// <summary>
    /// group code
    /// </summary>
    /// <value>group code</value>
    [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
    public string Code { get; }

    /// <summary>
    /// group description
    /// </summary>
    /// <value>group description</value>
    [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
    public string Description { get; }

    /// <summary>
    /// member count
    /// </summary>
    /// <value>member count</value>
    [DataMember(Name = "member_count", EmitDefaultValue = false)]
    public int MemberCount { get; }

    /// <summary>
    /// last time updated
    /// </summary>
    /// <value>last time updated</value>
    [DataMember(Name = "updated_at", EmitDefaultValue = false)]
    public DateTime UpdatedAt { get; }

    /// <summary>
    /// group members
    /// </summary>
    /// <value>group members</value>
    [DataMember(Name = "members", EmitDefaultValue = false)]
    public List<GroupMember> Members { get; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LocalGroup {\n");
        sb.Append("  Id: ").Append(Id).Append('\n');
        sb.Append("  Code: ").Append(Code).Append('\n');
        sb.Append("  Description: ").Append(Description).Append('\n');
        sb.Append("  MemberCount: ").Append(MemberCount).Append('\n');
        sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append('\n');
        sb.Append("  Members: ").Append(Members).Append('\n');
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
        return Equals(input as LocalGroup);
    }

    /// <summary>
    /// Returns true if LocalGroup instances are equal
    /// </summary>
    /// <param name="input">Instance of LocalGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LocalGroup input)
    {
        if (input == null) return false;
        return
            (
                Id == input.Id ||
                (Id != null &&
                 Id.Equals(input.Id))
            ) &&
            (
                Code == input.Code ||
                (Code != null &&
                 Code.Equals(input.Code))
            ) &&
            (
                Description == input.Description ||
                (Description != null &&
                 Description.Equals(input.Description))
            ) &&
            (
                MemberCount == input.MemberCount ||
                MemberCount.Equals(input.MemberCount)
            ) &&
            (
                UpdatedAt == input.UpdatedAt ||
                UpdatedAt.Equals(input.UpdatedAt)
            ) &&
            (
                Members == input.Members ||
                (Members != null &&
                 input.Members != null &&
                 Members.SequenceEqual(input.Members))
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
            if (Id != null) hashCode = hashCode * 59 + Id.GetHashCode();
            if (Code != null) hashCode = hashCode * 59 + Code.GetHashCode();
            if (Description != null) hashCode = hashCode * 59 + Description.GetHashCode();
            hashCode = hashCode * 59 + MemberCount.GetHashCode();
            hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
            if (Members != null) hashCode = hashCode * 59 + Members.GetHashCode();
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
        // Code (string) maxLength
        if (Code is {Length: > 255})
            yield return new ValidationResult("Invalid value for Code, length must be less than 255.", new[] {"Code"});

        // Code (string) minLength
        if (Code is {Length: < 1})
            yield return new ValidationResult("Invalid value for Code, length must be greater than 1.", new[] {"Code"});

        // Description (string) maxLength
        if (Description is {Length: > 255})
            yield return new ValidationResult("Invalid value for Description, length must be less than 255.",
                new[] {"Description"});

        // Description (string) minLength
        if (Description is {Length: < 1})
            yield return new ValidationResult("Invalid value for Description, length must be greater than 1.",
                new[] {"Description"});

        // MemberCount (int) maximum
        if (MemberCount > 1000000)
            yield return new ValidationResult(
                "Invalid value for MemberCount, must be a value less than or equal to 1000000.", new[] {"MemberCount"});

        // MemberCount (int) minimum
        if (MemberCount < 0)
            yield return new ValidationResult(
                "Invalid value for MemberCount, must be a value greater than or equal to 0.", new[] {"MemberCount"});
        // TODO
        // // UpdatedAt (DateTime) maxLength
        // if (UpdatedAt.Length > 24)
        // {
        //     yield return new ValidationResult("Invalid value for UpdatedAt, length must be less than 24.", new [] { "UpdatedAt" });
        // }
        //
        // // UpdatedAt (DateTime) minLength
        // if (UpdatedAt.Length < 24)
        // {
        //     yield return new ValidationResult("Invalid value for UpdatedAt, length must be greater than 24.", new [] { "UpdatedAt" });
        // }
    }
}