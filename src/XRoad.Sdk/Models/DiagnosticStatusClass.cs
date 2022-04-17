using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// diagnostics status class
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum DiagnosticStatusClass
{
    [EnumMember(Value = @"OK")] OK = 0,

    [EnumMember(Value = @"WAITING")] WAITING = 1,

    [EnumMember(Value = @"FAIL")] FAIL = 2,
}