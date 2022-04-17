using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// timestamping services
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TimestampingService
{
    /// <summary>
    /// name of the time stamping service
    /// </summary>
    [JsonProperty("name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Name { get; set; }

    /// <summary>
    /// url of the time stamping service
    /// </summary>
    [JsonProperty("url", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Url { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}