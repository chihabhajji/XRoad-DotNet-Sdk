using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk;

/// <summary>
/// subject type
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum ServiceClientType
{

    [EnumMember(Value = @"GLOBALGROUP")]
    GLOBALGROUP = 0,

    [EnumMember(Value = @"LOCALGROUP")]
    LOCALGROUP = 1,

    [EnumMember(Value = @"SUBSYSTEM")]
    SUBSYSTEM = 2,

}