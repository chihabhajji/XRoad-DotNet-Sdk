using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// certificate status
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum CertificateOcspStatus
{
    [EnumMember(Value = @"DISABLED")] DISABLED = 0,

    [EnumMember(Value = @"EXPIRED")] EXPIRED = 1,

    [EnumMember(Value = @"OCSP_RESPONSE_UNKNOWN")]
    OCSP_RESPONSE_UNKNOWN = 2,

    [EnumMember(Value = @"OCSP_RESPONSE_GOOD")]
    OCSP_RESPONSE_GOOD = 3,

    [EnumMember(Value = @"OCSP_RESPONSE_SUSPENDED")]
    OCSP_RESPONSE_SUSPENDED = 4,

    [EnumMember(Value = @"OCSP_RESPONSE_REVOKED")]
    OCSP_RESPONSE_REVOKED = 5,
}