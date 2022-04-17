using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk;

/// <summary>
/// certificate authority OCSP status
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum CertificateAuthorityOcspResponse
{

    [EnumMember(Value = @"NOT_AVAILABLE")]
    NOT_AVAILABLE = 0,

    [EnumMember(Value = @"OCSP_RESPONSE_UNKNOWN")]
    OCSP_RESPONSE_UNKNOWN = 1,

    [EnumMember(Value = @"OCSP_RESPONSE_GOOD")]
    OCSP_RESPONSE_GOOD = 2,

    [EnumMember(Value = @"OCSP_RESPONSE_SUSPENDED")]
    OCSP_RESPONSE_SUSPENDED = 3,

    [EnumMember(Value = @"OCSP_RESPONSE_REVOKED")]
    OCSP_RESPONSE_REVOKED = 4,

}