using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

#pragma warning disable 108, 114, 472, 1573, 1591, 8073, 3016, 8603
/// <summary>
/// object containing and array of AccessRights
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class AccessRights
{
    /// <summary>
    /// array of AccessRights
    /// </summary>
    [JsonProperty("items", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessRight> Items { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}