using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// Key and TokenCertificateSigningRequest id
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class KeyWithCertificateSigningRequestId
{
    [JsonProperty("key", Required = Required.Always)]
    [Required]
    public Key Key { get; set; } = new Key();

    /// <summary>
    /// CSR id
    /// </summary>
    [JsonProperty("csr_id", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Csr_id { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}