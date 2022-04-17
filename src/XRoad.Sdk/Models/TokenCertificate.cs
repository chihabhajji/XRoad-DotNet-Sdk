using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk;

/// <summary>
/// Certificate that is stored in a Token (auth or sign cert). Also includes the possible actions that can be done to this object, e.g DELETE (only for cert related operations and does not consider user authorization).
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TokenCertificate
{
    [JsonProperty("ocsp_status", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CertificateOcspStatus Ocsp_status { get; set; }

    /// <summary>
    /// client id of the owner member, &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;
    /// </summary>
    [JsonProperty("owner_id", Required = Required.Always)]
    [Required]
    [StringLength(767, MinimumLength = 1)]
    public string Owner_id { get; set; }

    /// <summary>
    /// if the certificate is active
    /// </summary>
    [JsonProperty("active", Required = Required.Always)]
    public bool Active { get; set; }

    /// <summary>
    /// if the certificate is saved to configuration
    /// </summary>
    [JsonProperty("saved_to_configuration", Required = Required.Always)]
    public bool Saved_to_configuration { get; set; }

    [JsonProperty("certificate_details", Required = Required.Always)]
    [Required]
    public CertificateDetails Certificate_details { get; set; } = new CertificateDetails();

    [JsonProperty("status", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CertificateStatus Status { get; set; }

    [JsonProperty("possible_actions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
    public PossibleActions Possible_actions { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}