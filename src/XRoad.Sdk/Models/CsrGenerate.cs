using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk.Models;

/// <summary>
/// request to generate a CSR
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class CsrGenerate
{
    [JsonProperty("key_usage_type", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public KeyUsageType Key_usage_type { get; set; }

    /// <summary>
    /// common name of the CA
    /// </summary>
    [JsonProperty("ca_name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Ca_name { get; set; }

    [JsonProperty("csr_format", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CsrFormat Csr_format { get; set; }

    /// <summary>
    /// member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;
    /// </summary>
    [JsonProperty("member_id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(767, MinimumLength = 1)]
    public string Member_id { get; set; }

    /// <summary>
    /// user-provided values for subject DN parameters
    /// </summary>
    [JsonProperty("subject_field_values", Required = Required.Always)]
    [Required]
    public IDictionary<string, string> Subject_field_values { get; set; } = new Dictionary<string, string>();

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}