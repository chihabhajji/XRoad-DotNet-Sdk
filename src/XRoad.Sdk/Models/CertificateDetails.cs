using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk.Models;

/// <summary>
/// certificate details for any kind of certificate (TLS, auth, sign)
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class CertificateDetails
{
    /// <summary>
    /// certificate issuer distinguished name
    /// </summary>
    [JsonProperty("issuer_distinguished_name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Issuer_distinguished_name { get; set; }

    /// <summary>
    /// certificate issuer common name
    /// </summary>
    [JsonProperty("issuer_common_name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Issuer_common_name { get; set; }

    /// <summary>
    /// certificate subject distinguished name
    /// </summary>
    [JsonProperty("subject_distinguished_name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Subject_distinguished_name { get; set; }

    /// <summary>
    /// certificate subject common name
    /// </summary>
    [JsonProperty("subject_common_name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Subject_common_name { get; set; }

    /// <summary>
    /// certificate validity not before
    /// </summary>
    [JsonProperty("not_before", Required = Required.Always)]
    [Required]
    [StringLength(24, MinimumLength = 24)]
    public DateTimeOffset Not_before { get; set; }

    /// <summary>
    /// certificate validity not after
    /// </summary>
    [JsonProperty("not_after", Required = Required.Always)]
    [Required]
    [StringLength(24, MinimumLength = 24)]
    public DateTimeOffset Not_after { get; set; }

    /// <summary>
    /// serial number
    /// </summary>
    [JsonProperty("serial", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Serial { get; set; }

    /// <summary>
    /// version
    /// </summary>
    [JsonProperty("version", Required = Required.Always)]
    public int Version { get; set; }

    /// <summary>
    /// certificate signature algorithm
    /// </summary>
    [JsonProperty("signature_algorithm", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Signature_algorithm { get; set; }

    /// <summary>
    /// hex encoded certificate signature
    /// </summary>
    [JsonProperty("signature", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Signature { get; set; }

    /// <summary>
    /// certificate public key algorithm
    /// </summary>
    [JsonProperty("public_key_algorithm", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Public_key_algorithm { get; set; }

    /// <summary>
    /// hex encoded RSA public key modulus (if RSA key)
    /// </summary>
    [JsonProperty("rsa_public_key_modulus", Required = Required.Always)]
    [Required]
    [StringLength(1000, MinimumLength = 1)]
    public string Rsa_public_key_modulus { get; set; }

    /// <summary>
    /// RSA public key exponent (if RSA key) as an integer
    /// </summary>
    [JsonProperty("rsa_public_key_exponent", Required = Required.Always)]
    public int Rsa_public_key_exponent { get; set; }

    /// <summary>
    /// certificate SHA-1 hash
    /// </summary>
    [JsonProperty("hash", Required = Required.Always)]
    [Required]
    [StringLength(40, MinimumLength = 1)]
    public string Hash { get; set; }

    /// <summary>
    /// certificate key usage array
    /// </summary>
    [JsonProperty("key_usages", Required = Required.Always, ItemConverterType = typeof(StringEnumConverter))]
    [Required]
    public ICollection<KeyUsage> Key_usages { get; set; } = new Collection<KeyUsage>();

    /// <summary>
    /// certificate subject alternative names
    /// </summary>
    [JsonProperty("subject_alternative_names", Required = Required.Always)]
    [Required]
    [StringLength(1000, MinimumLength = 1)]
    public string Subject_alternative_names { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}