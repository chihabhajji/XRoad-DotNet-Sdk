using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk.Models;

/// <summary>
/// configuration status
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum ConfigurationStatus
{
    /// <summary>
    /// Success
    /// </summary>
    [EnumMember(Value = @"SUCCESS")] SUCCESS = 0,

    /// <summary>
    /// Internal error
    /// </summary>
    [EnumMember(Value = @"ERROR_CODE_INTERNAL")]
    ERROR_CODE_INTERNAL = 1,

    /// <summary>
    /// Invalid signature value
    /// </summary>
    [EnumMember(Value = @"ERROR_CODE_INVALID_SIGNATURE_VALUE")]
    ERROR_CODE_INVALID_SIGNATURE_VALUE = 2,

    /// <summary>
    /// Expired configuration
    /// </summary>
    [EnumMember(Value = @"ERROR_CODE_EXPIRED_CONF")]
    ERROR_CODE_EXPIRED_CONF = 3,

    /// <summary>
    /// Cannot download configuration
    /// </summary>
    [EnumMember(Value = @"ERROR_CODE_CANNOT_DOWNLOAD_CONF")]
    ERROR_CODE_CANNOT_DOWNLOAD_CONF = 4,

    /// <summary>
    /// Missing private params
    /// </summary>
    [EnumMember(Value = @"ERROR_CODE_MISSING_PRIVATE_PARAMS")]
    ERROR_CODE_MISSING_PRIVATE_PARAMS = 5,

    /// <summary>
    /// Uninitialized 
    /// </summary>
    [EnumMember(Value = @"ERROR_CODE_UNINITIALIZED")]
    ERROR_CODE_UNINITIALIZED = 6,

    /// <summary>
    /// Unkown error
    /// </summary>
    [EnumMember(Value = @"UNKNOWN")] UNKNOWN = 7,
}