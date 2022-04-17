using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk;

/// <summary>
/// request object containing service description url, service code and type
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceDescriptionAdd
{
    /// <summary>
    /// path for the service description file
    /// </summary>
    [JsonProperty("url", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Url { get; set; }

    /// <summary>
    /// service code for REST service
    /// </summary>
    [JsonProperty("rest_service_code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(255, MinimumLength = 1)]
    public string Rest_service_code { get; set; }

    /// <summary>
    /// if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail
    /// </summary>
    [JsonProperty("ignore_warnings", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool Ignore_warnings { get; set; }

    [JsonProperty("type", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ServiceType Type { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}