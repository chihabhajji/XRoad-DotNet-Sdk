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
/// OCSP responder status
/// </summary>
/// <value>OCSP responder status</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum OcspStatus
{
    /// <summary>
    /// Enum SUCCESS for value: SUCCESS
    /// </summary>
    [EnumMember(Value = "SUCCESS")] SUCCESS = 1,

    /// <summary>
    /// Enum ERRORCODEOCSPCONNECTIONERROR for value: ERROR_CODE_OCSP_CONNECTION_ERROR
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_OCSP_CONNECTION_ERROR")]
    ERRORCODEOCSPCONNECTIONERROR = 2,

    /// <summary>
    /// Enum ERRORCODEOCSPFAILED for value: ERROR_CODE_OCSP_FAILED
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_OCSP_FAILED")]
    ERRORCODEOCSPFAILED = 3,

    /// <summary>
    /// Enum ERRORCODEOCSPRESPONSEINVALID for value: ERROR_CODE_OCSP_RESPONSE_INVALID
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_OCSP_RESPONSE_INVALID")]
    ERRORCODEOCSPRESPONSEINVALID = 4,

    /// <summary>
    /// Enum ERRORCODEOCSPUNINITIALIZED for value: ERROR_CODE_OCSP_UNINITIALIZED
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_OCSP_UNINITIALIZED")]
    ERRORCODEOCSPUNINITIALIZED = 5,

    /// <summary>
    /// Enum ERRORCODEOCSPRESPONSEUNVERIFIED for value: ERROR_CODE_OCSP_RESPONSE_UNVERIFIED
    /// </summary>
    [EnumMember(Value = "ERROR_CODE_OCSP_RESPONSE_UNVERIFIED")]
    ERRORCODEOCSPRESPONSEUNVERIFIED = 6,

    /// <summary>
    /// Enum UNKNOWN for value: UNKNOWN
    /// </summary>
    [EnumMember(Value = "UNKNOWN")] UNKNOWN = 7
}