using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// group member
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class GroupMember
{
    /// <summary>
    /// group member id
    /// </summary>
    [JsonProperty("id", Required = Required.Always)]
    [Required]
    [StringLength(1023, MinimumLength = 1)]
    public string Id { get; set; }

    /// <summary>
    /// group member name
    /// </summary>
    [JsonProperty("name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Name { get; set; }

    /// <summary>
    /// group member created at
    /// </summary>
    [JsonProperty("created_at", Required = Required.Always)]
    [Required]
    [StringLength(24, MinimumLength = 24)]
    public DateTimeOffset Created_at { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}