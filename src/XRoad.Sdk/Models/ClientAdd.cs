using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk;

/// <summary>
/// Request to add client. Carries a Client and ignore warnings parameter
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ClientAdd
{
    [JsonProperty("client", Required = Required.Always)]
    [Required]
    public Client Client { get; set; } = new Client();

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