using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// security server initial configuration
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class InitialServerConf
{
    /// <summary>
    /// member class
    /// </summary>
    [JsonProperty("owner_member_class", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Owner_member_class { get; set; }

    /// <summary>
    /// member code
    /// </summary>
    [JsonProperty("owner_member_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Owner_member_code { get; set; }

    /// <summary>
    /// security server code
    /// </summary>
    [JsonProperty("security_server_code", Required = Required.DisallowNull,
        NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Security_server_code { get; set; }

    /// <summary>
    /// pin code for the initial software token
    /// </summary>
    [JsonProperty("software_token_pin", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Software_token_pin { get; set; }

    /// <summary>
    /// if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail
    /// </summary>
    [JsonProperty("ignore_warnings", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool Ignore_warnings { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}