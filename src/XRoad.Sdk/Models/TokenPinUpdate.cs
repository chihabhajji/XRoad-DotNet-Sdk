using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TokenPinUpdate
{
    /// <summary>
    /// the old pin code of the token
    /// </summary>
    [JsonProperty("old_pin", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Old_pin { get; set; }

    /// <summary>
    /// the new pin code of the token
    /// </summary>
    [JsonProperty("new_pin", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string New_pin { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}