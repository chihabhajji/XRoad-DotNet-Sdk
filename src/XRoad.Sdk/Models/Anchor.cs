using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

#pragma warning disable 108, 114, 472, 1573, 1591, 8073, 3016, 8603
/// <summary>
/// security server anchor
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class Anchor
{
    /// <summary>
    /// anchor hash
    /// </summary>
    [JsonProperty("hash", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Hash { get; set; }

    /// <summary>
    /// anchor created at
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