using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk;

/// <summary>
/// service client. May be a subsystem, local group, or a global group
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceClient
{
    /// <summary>
    /// subject id - can be a subsystem id &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;:&lt;subsystem&gt; | globalgroup id &lt;instance_id&gt;:&lt;group_code&gt; | localgroup resource id in number format &lt;id&gt;
    /// </summary>
    [JsonProperty("id", Required = Required.Always)]
    [Required]
    [StringLength(1279, MinimumLength = 1)]
    public string Id { get; set; }

    /// <summary>
    /// name of the ServiceClient - can be the name of a member or the description of a group
    /// </summary>
    [JsonProperty("name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Name { get; set; }

    /// <summary>
    /// group code in case the object is a local group
    /// </summary>
    [JsonProperty("local_group_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Local_group_code { get; set; }

    [JsonProperty("service_client_type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ServiceClientType Service_client_type { get; set; }

    /// <summary>
    /// time when access right were given at. When listing client's service clients without specifying the service, the time when first service access right was given to this service client for any service. When listing service clients for a specific service, time when service client was added permission to that service.
    /// </summary>
    [JsonProperty("rights_given_at", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset Rights_given_at { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}