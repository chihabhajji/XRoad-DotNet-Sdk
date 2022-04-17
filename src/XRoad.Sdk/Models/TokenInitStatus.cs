using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// whether a token has been initialized or not – if the software token init status cannot be resolved (e.g. signer module is offline), the value is UNKNOWN
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum TokenInitStatus
{
    [EnumMember(Value = @"INITIALIZED")] INITIALIZED = 0,

    [EnumMember(Value = @"NOT_INITIALIZED")]
    NOT_INITIALIZED = 1,

    [EnumMember(Value = @"UNKNOWN")] UNKNOWN = 2,
}