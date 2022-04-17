using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk;

/// <summary>
/// service for the service description
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class Service
{
    /// <summary>
    /// encoded service id, including client id
    /// </summary>
    [JsonProperty("id", Required = Required.Always)]
    [Required]
    [StringLength(1279, MinimumLength = 1)]
    public string Id { get; set; }

    /// <summary>
    /// encoded service code and version
    /// </summary>
    [JsonProperty("full_service_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(511, MinimumLength = 1)]
    public string Full_service_code { get; set; }

    /// <summary>
    /// encoded service code
    /// </summary>
    [JsonProperty("service_code", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Service_code { get; set; }

    /// <summary>
    /// service time out value
    /// </summary>
    [JsonProperty("timeout", Required = Required.Always)]
    [Range(0, 1000)]
    public int Timeout { get; set; }

    /// <summary>
    /// service title
    /// </summary>
    [JsonProperty("title", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Title { get; set; }

    /// <summary>
    /// service ssl auth
    /// </summary>
    [JsonProperty("ssl_auth", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool Ssl_auth { get; set; }

    /// <summary>
    /// count of acl subjects
    /// </summary>
    [JsonProperty("subjects_count", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [Range(0, 100000)]
    public int Subjects_count { get; set; }

    /// <summary>
    /// service url
    /// </summary>
    [JsonProperty("url", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Url { get; set; }

    /// <summary>
    /// list of endpoints linked to this service
    /// </summary>
    [JsonProperty("endpoints", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Endpoint> Endpoints { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}