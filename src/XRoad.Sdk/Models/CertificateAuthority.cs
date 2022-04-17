using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk;

/// <summary>
/// approved certificate authority information. Only for top CAs.
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class CertificateAuthority
{
    /// <summary>
    /// name of the CA, as defined in global conf. Used also as an identifier
    /// </summary>
    [JsonProperty("name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Name { get; set; }

    /// <summary>
    /// subject distinguished name
    /// </summary>
    [JsonProperty("subject_distinguished_name", Required = Required.Always)]
    [Required]
    [StringLength(1024, MinimumLength = 1)]
    public string Subject_distinguished_name { get; set; }

    /// <summary>
    /// issuer distinguished name
    /// </summary>
    [JsonProperty("issuer_distinguished_name", Required = Required.Always)]
    [Required]
    [StringLength(1024, MinimumLength = 1)]
    public string Issuer_distinguished_name { get; set; }

    [JsonProperty("ocsp_response", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public CertificateAuthorityOcspResponse Ocsp_response { get; set; }

    /// <summary>
    /// certificate authority expires at
    /// </summary>
    [JsonProperty("not_after", Required = Required.Always)]
    [Required]
    [StringLength(24, MinimumLength = 24)]
    public DateTimeOffset Not_after { get; set; }

    /// <summary>
    /// if the certificate authority is top CA (instead of intermediate)
    /// </summary>
    [JsonProperty("top_ca", Required = Required.Always)]
    public bool Top_ca { get; set; }

    /// <summary>
    /// encoded path string from this CA to top CA
    /// </summary>
    [JsonProperty("path", Required = Required.Always)]
    [Required]
    public string Path { get; set; }

    /// <summary>
    /// if certificate authority is limited for authentication use only
    /// </summary>
    [JsonProperty("authentication_only", Required = Required.Always)]
    public bool Authentication_only { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}