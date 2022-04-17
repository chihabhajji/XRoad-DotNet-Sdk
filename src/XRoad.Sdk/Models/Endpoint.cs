using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk;

/// <summary>
/// Endpoint for a service
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class Endpoint
{
    /// <summary>
    /// unique identifier
    /// </summary>
    [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("service_code", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Service_code { get; set; }

    /// <summary>
    /// http method mapped to this endpoint
    /// </summary>
    [JsonProperty("method", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EndpointMethod Method { get; set; }

    /// <summary>
    /// relative path where this endpoint is mapped to
    /// </summary>
    [JsonProperty("path", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Path { get; set; }

    /// <summary>
    /// has endpoint been generated from openapi3 description
    /// </summary>
    [JsonProperty("generated", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool Generated { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}