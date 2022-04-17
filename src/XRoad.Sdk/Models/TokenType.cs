using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// token type
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum TokenType
{
    [EnumMember(Value = @"SOFTWARE")] SOFTWARE = 0,

    [EnumMember(Value = @"HARDWARE")] HARDWARE = 1,
}