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
/// connection type
/// </summary>
/// <value>connection type</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConnectionType
{
    /// <summary>
    /// Enum HTTP for value: HTTP
    /// </summary>
    [EnumMember(Value = "HTTP")] HTTP = 1,

    /// <summary>
    /// Enum HTTPS for value: HTTPS
    /// </summary>
    [EnumMember(Value = "HTTPS")] HTTPS = 2,

    /// <summary>
    /// Enum HTTPSNOAUTH for value: HTTPS_NO_AUTH
    /// </summary>
    [EnumMember(Value = "HTTPS_NO_AUTH")] HTTPSNOAUTH = 3
}