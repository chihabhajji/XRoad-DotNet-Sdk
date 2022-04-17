using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// token type
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum TokenStatus
{
    [EnumMember(Value = @"OK")] OK = 0,

    [EnumMember(Value = @"USER_PIN_LOCKED")]
    USER_PIN_LOCKED = 1,

    [EnumMember(Value = @"USER_PIN_INCORRECT")]
    USER_PIN_INCORRECT = 2,

    [EnumMember(Value = @"USER_PIN_INVALID")]
    USER_PIN_INVALID = 3,

    [EnumMember(Value = @"USER_PIN_EXPIRED")]
    USER_PIN_EXPIRED = 4,

    [EnumMember(Value = @"USER_PIN_COUNT_LOW")]
    USER_PIN_COUNT_LOW = 5,

    [EnumMember(Value = @"USER_PIN_FINAL_TRY")]
    USER_PIN_FINAL_TRY = 6,

    [EnumMember(Value = @"NOT_INITIALIZED")]
    NOT_INITIALIZED = 7,
}