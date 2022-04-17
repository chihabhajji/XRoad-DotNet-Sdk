using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk;

/// <summary>
/// Object for updating endpoints method and/or path
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class EndpointUpdate
{
    /// <summary>
    /// http method mapped to this endpoint
    /// </summary>
    [JsonProperty("method", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public EndpointUpdateMethod Method { get; set; }

    /// <summary>
    /// relative path where this endpoint is mapped to
    /// </summary>
    [JsonProperty("path", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Path { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}