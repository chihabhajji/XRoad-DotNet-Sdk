using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk;

#pragma warning disable 108, 114, 472, 1573, 1591, 8073, 3016, 8603
/// <summary>
/// access right given for a specific subject (ServiceClient) for specific service (service_code) owned by some client. This object does not represent endpoint-level access rights
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class AccessRight
{
    /// <summary>
    /// service code
    /// </summary>
    [JsonProperty("service_code", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Service_code { get; set; }

    /// <summary>
    /// service title
    /// </summary>
    [JsonProperty("service_title", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Service_title { get; set; }

    /// <summary>
    /// access right given at
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