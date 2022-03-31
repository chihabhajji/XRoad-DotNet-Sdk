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
/// token type
/// </summary>
/// <value>token type</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum TokenStatus
{
    /// <summary>
    /// Enum OK for value: OK
    /// </summary>
    [EnumMember(Value = "OK")] OK = 1,

    /// <summary>
    /// Enum USERPINLOCKED for value: USER_PIN_LOCKED
    /// </summary>
    [EnumMember(Value = "USER_PIN_LOCKED")]
    USERPINLOCKED = 2,

    /// <summary>
    /// Enum USERPININCORRECT for value: USER_PIN_INCORRECT
    /// </summary>
    [EnumMember(Value = "USER_PIN_INCORRECT")]
    USERPININCORRECT = 3,

    /// <summary>
    /// Enum USERPININVALID for value: USER_PIN_INVALID
    /// </summary>
    [EnumMember(Value = "USER_PIN_INVALID")]
    USERPININVALID = 4,

    /// <summary>
    /// Enum USERPINEXPIRED for value: USER_PIN_EXPIRED
    /// </summary>
    [EnumMember(Value = "USER_PIN_EXPIRED")]
    USERPINEXPIRED = 5,

    /// <summary>
    /// Enum USERPINCOUNTLOW for value: USER_PIN_COUNT_LOW
    /// </summary>
    [EnumMember(Value = "USER_PIN_COUNT_LOW")]
    USERPINCOUNTLOW = 6,

    /// <summary>
    /// Enum USERPINFINALTRY for value: USER_PIN_FINAL_TRY
    /// </summary>
    [EnumMember(Value = "USER_PIN_FINAL_TRY")]
    USERPINFINALTRY = 7,

    /// <summary>
    /// Enum NOTINITIALIZED for value: NOT_INITIALIZED
    /// </summary>
    [EnumMember(Value = "NOT_INITIALIZED")]
    NOTINITIALIZED = 8
}