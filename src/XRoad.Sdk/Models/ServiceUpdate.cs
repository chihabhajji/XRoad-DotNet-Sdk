using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// object for updating a service or all services within service description
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceUpdate
{
    /// <summary>
    /// service url
    /// </summary>
    [JsonProperty("url", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Url { get; set; }

    /// <summary>
    /// service time out value
    /// </summary>
    [JsonProperty("timeout", Required = Required.Always)]
    [Range(0, 1000)]
    public int Timeout { get; set; }

    /// <summary>
    /// service ssl auth
    /// </summary>
    [JsonProperty("ssl_auth", Required = Required.Always)]
    public bool Ssl_auth { get; set; }

    /// <summary>
    /// url is applied for all services
    /// </summary>
    [JsonProperty("url_all", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool Url_all { get; set; }

    /// <summary>
    /// timeout value is applied for all services
    /// </summary>
    [JsonProperty("timeout_all", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool Timeout_all { get; set; }

    /// <summary>
    /// ssl authentication is applied for all services
    /// </summary>
    [JsonProperty("ssl_auth_all", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool Ssl_auth_all { get; set; }

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