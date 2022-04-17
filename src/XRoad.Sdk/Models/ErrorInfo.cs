using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// object returned in error cases
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ErrorInfo
{
    /// <summary>
    /// http status code
    /// </summary>
    [JsonProperty("status", Required = Required.Always)]
    public int Status { get; set; }

    [JsonProperty("error", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public CodeWithDetails Error { get; set; }

    /// <summary>
    /// warnings that could be ignored
    /// </summary>
    [JsonProperty("warnings", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CodeWithDetails> Warnings { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}