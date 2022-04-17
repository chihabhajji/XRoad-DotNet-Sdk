using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum EndpointUpdateMethod
{
    [EnumMember(Value = @"*")] _ = 0,

    [EnumMember(Value = @"GET")] GET = 1,

    [EnumMember(Value = @"POST")] POST = 2,

    [EnumMember(Value = @"PUT")] PUT = 3,

    [EnumMember(Value = @"DELETE")] DELETE = 4,

    [EnumMember(Value = @"PATCH")] PATCH = 5,

    [EnumMember(Value = @"HEAD")] HEAD = 6,

    [EnumMember(Value = @"OPTIONS")] OPTIONS = 7,

    [EnumMember(Value = @"TRACE")] TRACE = 8,
}