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
/// certificate authority OCSP status
/// </summary>
/// <value>certificate authority OCSP status</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum CertificateAuthorityOcspResponse
{
    /// <summary>
    /// Enum NOTAVAILABLE for value: NOT_AVAILABLE
    /// </summary>
    [EnumMember(Value = "NOT_AVAILABLE")] NOTAVAILABLE = 1,

    /// <summary>
    /// Enum OCSPRESPONSEUNKNOWN for value: OCSP_RESPONSE_UNKNOWN
    /// </summary>
    [EnumMember(Value = "OCSP_RESPONSE_UNKNOWN")]
    OCSPRESPONSEUNKNOWN = 2,

    /// <summary>
    /// Enum OCSPRESPONSEGOOD for value: OCSP_RESPONSE_GOOD
    /// </summary>
    [EnumMember(Value = "OCSP_RESPONSE_GOOD")]
    OCSPRESPONSEGOOD = 3,

    /// <summary>
    /// Enum OCSPRESPONSESUSPENDED for value: OCSP_RESPONSE_SUSPENDED
    /// </summary>
    [EnumMember(Value = "OCSP_RESPONSE_SUSPENDED")]
    OCSPRESPONSESUSPENDED = 4,

    /// <summary>
    /// Enum OCSPRESPONSEREVOKED for value: OCSP_RESPONSE_REVOKED
    /// </summary>
    [EnumMember(Value = "OCSP_RESPONSE_REVOKED")]
    OCSPRESPONSEREVOKED = 5
}