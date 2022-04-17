using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TokenPassword
{
    /// <summary>
    /// password for logging in to the token
    /// </summary>
    [JsonProperty("password", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(int.MaxValue, MinimumLength = 1)]
    public string Password { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}