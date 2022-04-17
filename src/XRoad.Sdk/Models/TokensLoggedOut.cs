using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// response that tells if hsm tokens were logged out during the restore process
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TokensLoggedOut
{
    /// <summary>
    /// whether any hsm tokens were logged out during the restore process
    /// </summary>
    [JsonProperty("hsm_tokens_logged_out", Required = Required.DisallowNull,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool Hsm_tokens_logged_out { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}