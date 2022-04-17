using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk;

/// <summary>
/// key-value pair of strings
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class KeyValuePair
{
    /// <summary>
    /// key
    /// </summary>
    [JsonProperty("key", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Key { get; set; }

    /// <summary>
    /// value
    /// </summary>
    [JsonProperty("value", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Value { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}