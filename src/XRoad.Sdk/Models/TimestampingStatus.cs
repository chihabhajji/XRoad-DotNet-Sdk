using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// timestamping status
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum TimestampingStatus
{
    [EnumMember(Value = @"SUCCESS")] SUCCESS = 0,

    [EnumMember(Value = @"ERROR_CODE_TIMESTAMP_REQUEST_TIMED_OUT")]
    ERROR_CODE_TIMESTAMP_REQUEST_TIMED_OUT = 1,

    [EnumMember(Value = @"ERROR_CODE_MALFORMED_TIMESTAMP_SERVER_URL")]
    ERROR_CODE_MALFORMED_TIMESTAMP_SERVER_URL = 2,

    [EnumMember(Value = @"ERROR_CODE_TIMESTAMP_UNINITIALIZED")]
    ERROR_CODE_TIMESTAMP_UNINITIALIZED = 3,

    [EnumMember(Value = @"ERROR_CODE_INTERNAL")]
    ERROR_CODE_INTERNAL = 4,

    [EnumMember(Value = @"UNKNOWN")] UNKNOWN = 5,
}