using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// certificate key usage
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum KeyUsage
{
    [EnumMember(Value = @"DIGITAL_SIGNATURE")]
    DIGITAL_SIGNATURE = 0,

    [EnumMember(Value = @"NON_REPUDIATION")]
    NON_REPUDIATION = 1,

    [EnumMember(Value = @"KEY_ENCIPHERMENT")]
    KEY_ENCIPHERMENT = 2,

    [EnumMember(Value = @"DATA_ENCIPHERMENT")]
    DATA_ENCIPHERMENT = 3,

    [EnumMember(Value = @"KEY_AGREEMENT")] KEY_AGREEMENT = 4,

    [EnumMember(Value = @"KEY_CERT_SIGN")] KEY_CERT_SIGN = 5,

    [EnumMember(Value = @"CRL_SIGN")] CRL_SIGN = 6,

    [EnumMember(Value = @"ENCIPHER_ONLY")] ENCIPHER_ONLY = 7,

    [EnumMember(Value = @"DECIPHER_ONLY")] DECIPHER_ONLY = 8,
}