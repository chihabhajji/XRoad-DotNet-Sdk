using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk;

/// <summary>
/// Initialization status of the Security Server
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class InitializationStatus
{
    /// <summary>
    /// whether a configuration anchor has been imported or not
    /// </summary>
    [JsonProperty("is_anchor_imported", Required = Required.Always)]
    public bool Is_anchor_imported { get; set; }

    /// <summary>
    /// whether the server code of the security server has been initialized or not
    /// </summary>
    [JsonProperty("is_server_code_initialized", Required = Required.Always)]
    public bool Is_server_code_initialized { get; set; }

    /// <summary>
    /// whether the server owner of the security server has been initialized or not
    /// </summary>
    [JsonProperty("is_server_owner_initialized", Required = Required.Always)]
    public bool Is_server_owner_initialized { get; set; }

    [JsonProperty("software_token_init_status", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public TokenInitStatus Software_token_init_status { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}