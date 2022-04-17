using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk;

/// <summary>
/// model for adding a new LocalGroup
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class LocalGroupAdd
{
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

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}