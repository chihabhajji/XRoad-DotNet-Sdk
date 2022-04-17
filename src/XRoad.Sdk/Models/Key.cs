using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk.Models;

/// <summary>
/// Key for the certificate. Also includes the possible actions that can be done to this object, e.g DELETE (only for key related operations and does not consider user authorization).
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class Key
{
    /// <summary>
    /// key id
    /// </summary>
    [JsonProperty("id", Required = Required.Always)]
    [Required]
    public string Id { get; set; }

    /// <summary>
    /// key name
    /// </summary>
    [JsonProperty("name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Name { get; set; }

    /// <summary>
    /// key label
    /// </summary>
    [JsonProperty("label", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Label { get; set; }

    /// <summary>
    /// list of certificates for the key
    /// </summary>
    [JsonProperty("certificates", Required = Required.Always)]
    [Required]
    public ICollection<TokenCertificate> Certificates { get; set; } = new Collection<TokenCertificate>();

    /// <summary>
    /// list of CSRs for the key
    /// </summary>
    [JsonProperty("certificate_signing_requests", Required = Required.Always)]
    [Required]
    public ICollection<TokenCertificateSigningRequest> Certificate_signing_requests { get; set; } =
        new Collection<TokenCertificateSigningRequest>();

    [JsonProperty("usage", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public KeyUsageType Usage { get; set; }

    /// <summary>
    /// if the key is available
    /// </summary>
    [JsonProperty("available", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public bool Available { get; set; }

    /// <summary>
    /// if the key is saved to configuration
    /// </summary>
    [JsonProperty("saved_to_configuration", Required = Required.DisallowNull,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool Saved_to_configuration { get; set; }

    [JsonProperty("possible_actions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore,
        ItemConverterType = typeof(StringEnumConverter))]
    public PossibleActions Possible_actions { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}