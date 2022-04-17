using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk.Models;

/// <summary>
/// CSR for certificate that is stored in a Token. Also includes the possible actions that can be done to this object, e.g DELETE (only for csr related operations and does not consider user authorization).
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TokenCertificateSigningRequest
{
    /// <summary>
    /// CSR id
    /// </summary>
    [JsonProperty("id", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Id { get; set; }

    /// <summary>
    /// client id of the owner member, &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;
    /// </summary>
    [JsonProperty("owner_id", Required = Required.Always)]
    [Required]
    [StringLength(767, MinimumLength = 1)]
    public string Owner_id { get; set; }

    [JsonProperty("possible_actions", Required = Required.Always, ItemConverterType = typeof(StringEnumConverter))]
    [Required]
    public PossibleActions Possible_actions { get; set; } = new PossibleActions();

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}