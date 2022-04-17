using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk;

/// <summary>
/// connection type
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum ConnectionType
{

    [EnumMember(Value = @"HTTP")]
    HTTP = 0,

    [EnumMember(Value = @"HTTPS")]
    HTTPS = 1,

    [EnumMember(Value = @"HTTPS_NO_AUTH")]
    HTTPS_NO_AUTH = 2,

}