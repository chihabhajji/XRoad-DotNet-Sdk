using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// security server information
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class SecurityServer
{
    /// <summary>
    /// &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;:&lt;security_server_code&gt;
    /// </summary>
    [JsonProperty("id", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Id { get; set; }

    /// <summary>
    /// xroad instance id
    /// </summary>
    [JsonProperty("instance_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Instance_id { get; set; }

    /// <summary>
    /// member class
    /// </summary>
    [JsonProperty("member_class", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Member_class { get; set; }

    /// <summary>
    /// member code
    /// </summary>
    [JsonProperty("member_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Member_code { get; set; }

    /// <summary>
    /// security server code
    /// </summary>
    [JsonProperty("server_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Server_code { get; set; }

    /// <summary>
    /// security server address (ip or name)
    /// </summary>
    [JsonProperty("server_address", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255)]
    public string Server_address { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}