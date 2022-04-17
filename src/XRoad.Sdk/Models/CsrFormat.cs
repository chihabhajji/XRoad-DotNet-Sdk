using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// format of the certificate signing request (PEM or DER)
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum CsrFormat
{
    [EnumMember(Value = @"PEM")] PEM = 0,

    [EnumMember(Value = @"DER")] DER = 1,
}