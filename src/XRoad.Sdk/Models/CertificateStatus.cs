using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// certificate status
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum CertificateStatus
{
    [EnumMember(Value = @"SAVED")] SAVED = 0,

    [EnumMember(Value = @"REGISTRATION_IN_PROGRESS")]
    REGISTRATION_IN_PROGRESS = 1,

    [EnumMember(Value = @"REGISTERED")] REGISTERED = 2,

    [EnumMember(Value = @"DELETION_IN_PROGRESS")]
    DELETION_IN_PROGRESS = 3,

    [EnumMember(Value = @"GLOBAL_ERROR")] GLOBAL_ERROR = 4,
}