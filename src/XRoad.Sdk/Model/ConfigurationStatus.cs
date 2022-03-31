/*
 * X-Road Security Server Admin API
 *
 * X-Road Security Server Admin API. Note that the error metadata responses described in some endpoints are subjects to change and may be updated in upcoming versions.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: info@niis.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk.Model;

/// <summary>
/// configuration status
/// </summary>
/// <value>configuration status</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConfigurationStatus
{
    /// <summary>
    /// Enum SUCCESS for value: SUCCESS
    /// </summary>
    [EnumMember(Value = "SUCCESS")] SUCCESS = 1,

    /// <summary>
    /// Enum ERRORCODEINTERNAL for value: ERROR_CODE_INTERNAL
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_INTERNAL")]
    ERRORCODEINTERNAL = 2,

    /// <summary>
    /// Enum ERRORCODEINVALIDSIGNATUREVALUE for value: ERROR_CODE_INVALID_SIGNATURE_VALUE
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_INVALID_SIGNATURE_VALUE")]
    ERRORCODEINVALIDSIGNATUREVALUE = 3,

    /// <summary>
    /// Enum ERRORCODEEXPIREDCONF for value: ERROR_CODE_EXPIRED_CONF
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_EXPIRED_CONF")]
    ERRORCODEEXPIREDCONF = 4,

    /// <summary>
    /// Enum ERRORCODECANNOTDOWNLOADCONF for value: ERROR_CODE_CANNOT_DOWNLOAD_CONF
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_CANNOT_DOWNLOAD_CONF")]
    ERRORCODECANNOTDOWNLOADCONF = 5,

    /// <summary>
    /// Enum ERRORCODEMISSINGPRIVATEPARAMS for value: ERROR_CODE_MISSING_PRIVATE_PARAMS
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_MISSING_PRIVATE_PARAMS")]
    ERRORCODEMISSINGPRIVATEPARAMS = 6,

    /// <summary>
    /// Enum ERRORCODEUNINITIALIZED for value: ERROR_CODE_UNINITIALIZED
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_UNINITIALIZED")]
    ERRORCODEUNINITIALIZED = 7,

    /// <summary>
    /// Enum UNKNOWN for value: UNKNOWN
    /// </summary>
    [EnumMember(Value = "UNKNOWN")] UNKNOWN = 8
}