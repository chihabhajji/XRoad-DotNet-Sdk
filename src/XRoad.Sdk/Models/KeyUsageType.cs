using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk;

/// <summary>
/// intended usage for the key (signing or authentication)
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum KeyUsageType
{

    [EnumMember(Value = @"AUTHENTICATION")]
    AUTHENTICATION = 0,

    [EnumMember(Value = @"SIGNING")]
    SIGNING = 1,

}