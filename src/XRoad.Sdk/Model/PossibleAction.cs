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
/// an action to change state or edit token, key, cert or csr
/// </summary>
/// <value>an action to change state or edit token, key, cert or csr</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum PossibleAction
{
    /// <summary>
    /// Enum DELETE for value: DELETE
    /// </summary>
    [EnumMember(Value = "DELETE")] DELETE = 1,

    /// <summary>
    /// Enum ACTIVATE for value: ACTIVATE
    /// </summary>
    [EnumMember(Value = "ACTIVATE")] ACTIVATE = 2,

    /// <summary>
    /// Enum DISABLE for value: DISABLE
    /// </summary>
    [EnumMember(Value = "DISABLE")] DISABLE = 3,

    /// <summary>
    /// Enum LOGIN for value: LOGIN
    /// </summary>
    [EnumMember(Value = "LOGIN")] LOGIN = 4,

    /// <summary>
    /// Enum LOGOUT for value: LOGOUT
    /// </summary>
    [EnumMember(Value = "LOGOUT")] LOGOUT = 5,

    /// <summary>
    /// Enum REGISTER for value: REGISTER
    /// </summary>
    [EnumMember(Value = "REGISTER")] REGISTER = 6,

    /// <summary>
    /// Enum UNREGISTER for value: UNREGISTER
    /// </summary>
    [EnumMember(Value = "UNREGISTER")] UNREGISTER = 7,

    /// <summary>
    /// Enum IMPORTFROMTOKEN for value: IMPORT_FROM_TOKEN
    /// </summary>
    [EnumMember(Value = "IMPORT_FROM_TOKEN")]
    IMPORTFROMTOKEN = 8,

    /// <summary>
    /// Enum GENERATEKEY for value: GENERATE_KEY
    /// </summary>
    [EnumMember(Value = "GENERATE_KEY")] GENERATEKEY = 9,

    /// <summary>
    /// Enum EDITFRIENDLYNAME for value: EDIT_FRIENDLY_NAME
    /// </summary>
    [EnumMember(Value = "EDIT_FRIENDLY_NAME")]
    EDITFRIENDLYNAME = 10,

    /// <summary>
    /// Enum GENERATEAUTHCSR for value: GENERATE_AUTH_CSR
    /// </summary>
    [EnumMember(Value = "GENERATE_AUTH_CSR")]
    GENERATEAUTHCSR = 11,

    /// <summary>
    /// Enum GENERATESIGNCSR for value: GENERATE_SIGN_CSR
    /// </summary>
    [EnumMember(Value = "GENERATE_SIGN_CSR")]
    GENERATESIGNCSR = 12,

    /// <summary>
    /// Enum TOKENCHANGEPIN for value: TOKEN_CHANGE_PIN
    /// </summary>
    [EnumMember(Value = "TOKEN_CHANGE_PIN")]
    TOKENCHANGEPIN = 13
}