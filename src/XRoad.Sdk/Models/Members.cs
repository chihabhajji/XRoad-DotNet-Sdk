using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// Request object containing an array of member ids. The id must be an X-Road member id or subsystem id
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class Members
{
    /// <summary>
    /// array of members to be added
    /// </summary>
    [JsonProperty("items", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string> Items { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}