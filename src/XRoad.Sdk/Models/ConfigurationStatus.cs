using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk;

/// <summary>
/// configuration status
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum ConfigurationStatus
{

    [EnumMember(Value = @"SUCCESS")]
    SUCCESS = 0,

    [EnumMember(Value = @"ERROR_CODE_INTERNAL")]
    ERROR_CODE_INTERNAL = 1,

    [EnumMember(Value = @"ERROR_CODE_INVALID_SIGNATURE_VALUE")]
    ERROR_CODE_INVALID_SIGNATURE_VALUE = 2,

    [EnumMember(Value = @"ERROR_CODE_EXPIRED_CONF")]
    ERROR_CODE_EXPIRED_CONF = 3,

    [EnumMember(Value = @"ERROR_CODE_CANNOT_DOWNLOAD_CONF")]
    ERROR_CODE_CANNOT_DOWNLOAD_CONF = 4,

    [EnumMember(Value = @"ERROR_CODE_MISSING_PRIVATE_PARAMS")]
    ERROR_CODE_MISSING_PRIVATE_PARAMS = 5,

    [EnumMember(Value = @"ERROR_CODE_UNINITIALIZED")]
    ERROR_CODE_UNINITIALIZED = 6,

    [EnumMember(Value = @"UNKNOWN")]
    UNKNOWN = 7,

}