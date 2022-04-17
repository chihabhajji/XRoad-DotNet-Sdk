using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// object containing and array of ServiceClients
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceClients
{
    /// <summary>
    /// array of ServiceClients
    /// </summary>
    [JsonProperty("items", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceClient> Items { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}