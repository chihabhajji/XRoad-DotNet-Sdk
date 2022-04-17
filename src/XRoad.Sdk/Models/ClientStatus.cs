using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk;

/// <summary>
/// client status
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum ClientStatus
{

    [EnumMember(Value = @"REGISTERED")]
    REGISTERED = 0,

    [EnumMember(Value = @"SAVED")]
    SAVED = 1,

    [EnumMember(Value = @"GLOBAL_ERROR")]
    GLOBAL_ERROR = 2,

    [EnumMember(Value = @"REGISTRATION_IN_PROGRESS")]
    REGISTRATION_IN_PROGRESS = 3,

    [EnumMember(Value = @"DELETION_IN_PROGRESS")]
    DELETION_IN_PROGRESS = 4,

}