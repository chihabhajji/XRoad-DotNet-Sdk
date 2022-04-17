using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk;

/// <summary>
/// OCSP responder status
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum OcspStatus
{

    [EnumMember(Value = @"SUCCESS")]
    SUCCESS = 0,

    [EnumMember(Value = @"ERROR_CODE_OCSP_CONNECTION_ERROR")]
    ERROR_CODE_OCSP_CONNECTION_ERROR = 1,

    [EnumMember(Value = @"ERROR_CODE_OCSP_FAILED")]
    ERROR_CODE_OCSP_FAILED = 2,

    [EnumMember(Value = @"ERROR_CODE_OCSP_RESPONSE_INVALID")]
    ERROR_CODE_OCSP_RESPONSE_INVALID = 3,

    [EnumMember(Value = @"ERROR_CODE_OCSP_UNINITIALIZED")]
    ERROR_CODE_OCSP_UNINITIALIZED = 4,

    [EnumMember(Value = @"ERROR_CODE_OCSP_RESPONSE_UNVERIFIED")]
    ERROR_CODE_OCSP_RESPONSE_UNVERIFIED = 5,

    [EnumMember(Value = @"UNKNOWN")]
    UNKNOWN = 6,

}