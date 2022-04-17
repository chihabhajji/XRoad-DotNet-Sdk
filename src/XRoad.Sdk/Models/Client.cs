using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk.Models;

/// <summary>
/// x-road client
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class Client
{
    /// <summary>
    /// &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;:&lt;subsystem&gt;(optional). Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters
    /// </summary>
    [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(1023, MinimumLength = 1)]
    public string Id { get; set; }

    /// <summary>
    /// Xroad instance id. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters
    /// </summary>
    [JsonProperty("instance_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Instance_id { get; set; }

    /// <summary>
    /// Member name. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters
    /// </summary>
    [JsonProperty("member_name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Member_name { get; set; }

    /// <summary>
    /// Member class. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters
    /// </summary>
    [JsonProperty("member_class", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Member_class { get; set; }

    /// <summary>
    /// Member code. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters
    /// </summary>
    [JsonProperty("member_code", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Member_code { get; set; }

    /// <summary>
    /// Subsystem code. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters
    /// </summary>
    [JsonProperty("subsystem_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Subsystem_code { get; set; }

    /// <summary>
    /// if this client is the owner member of this security server
    /// </summary>
    [JsonProperty("owner", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool Owner { get; set; }

    /// <summary>
    /// if this client has a valid (registered and with good OCSP response) sign cert stored on this security server
    /// </summary>
    [JsonProperty("has_valid_local_sign_cert", Required = Required.DisallowNull,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool Has_valid_local_sign_cert { get; set; }

    [JsonProperty("connection_type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ConnectionType Connection_type { get; set; }

    [JsonProperty("status", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ClientStatus Status { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}