using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class KeyLabelWithCsrGenerate
{
    /// <summary>
    /// label for the new key
    /// </summary>
    [JsonProperty("key_label", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [StringLength(255)]
    public string Key_label { get; set; }

    [JsonProperty("csr_generate_request", Required = Required.Always)]
    [Required]
    public CsrGenerate Csr_generate_request { get; set; } = new CsrGenerate();

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}