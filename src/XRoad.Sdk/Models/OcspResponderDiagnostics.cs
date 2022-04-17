using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk;

/// <summary>
/// Ocsp responder diagnostics
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class OcspResponderDiagnostics
{
    /// <summary>
    /// CA distinguished name
    /// </summary>
    [JsonProperty("distinguished_name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Distinguished_name { get; set; }

    [JsonProperty("ocsp_responders", Required = Required.Always)]
    [Required]
    public ICollection<OcspResponder> Ocsp_responders { get; set; } = new Collection<OcspResponder>();

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}