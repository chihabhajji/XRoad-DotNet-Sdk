using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk;

/// <summary>
/// service type
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum ServiceType
{

    [EnumMember(Value = @"WSDL")]
    WSDL = 0,

    [EnumMember(Value = @"REST")]
    REST = 1,

    [EnumMember(Value = @"OPENAPI3")]
    OPENAPI3 = 2,

}