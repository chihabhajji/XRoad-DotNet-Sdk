using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk;

/// <summary>
/// WSDL/OPENAPI3/REST service
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceDescription
{
    /// <summary>
    /// unique identifier
    /// </summary>
    [JsonProperty("id", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Id { get; set; }

    /// <summary>
    /// service url
    /// </summary>
    [JsonProperty("url", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Url { get; set; }

    [JsonProperty("type", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ServiceType Type { get; set; }

    /// <summary>
    /// service disabled
    /// </summary>
    [JsonProperty("disabled", Required = Required.Always)]
    public bool Disabled { get; set; }

    /// <summary>
    /// disabled notice
    /// </summary>
    [JsonProperty("disabled_notice", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [StringLength(255)]
    public string Disabled_notice { get; set; }

    /// <summary>
    /// time for service refresh
    /// </summary>
    [JsonProperty("refreshed_at", Required = Required.Always)]
    [Required]
    [StringLength(24, MinimumLength = 24)]
    public DateTimeOffset Refreshed_at { get; set; }

    /// <summary>
    /// service description services
    /// </summary>
    [JsonProperty("services", Required = Required.Always)]
    [Required]
    public ICollection<Service> Services { get; set; } = new Collection<Service>();

    /// <summary>
    /// &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;:&lt;subsystem&gt;(optional)
    /// </summary>
    [JsonProperty("client_id", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Client_id { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}