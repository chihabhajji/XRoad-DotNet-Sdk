using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// group
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class LocalGroup
{
    /// <summary>
    /// unique identifier
    /// </summary>
    [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    /// <summary>
    /// group code
    /// </summary>
    [JsonProperty("code", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Code { get; set; }

    /// <summary>
    /// group description
    /// </summary>
    [JsonProperty("description", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Description { get; set; }

    /// <summary>
    /// member count
    /// </summary>
    [JsonProperty("member_count", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [Range(0, 1000000)]
    public int Member_count { get; set; }

    /// <summary>
    /// last time updated
    /// </summary>
    [JsonProperty("updated_at", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(24, MinimumLength = 24)]
    public DateTimeOffset Updated_at { get; set; }

    /// <summary>
    /// group members
    /// </summary>
    [JsonProperty("members", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GroupMember> Members { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}