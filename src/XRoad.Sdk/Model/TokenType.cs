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
public enum TokenType
{
    /// <summary>
    /// Enum SOFTWARE for value: SOFTWARE
    /// </summary>
    [EnumMember(Value = "SOFTWARE")] SOFTWARE = 1,

    /// <summary>
    /// Enum HARDWARE for value: HARDWARE
    /// </summary>
    [EnumMember(Value = "HARDWARE")] HARDWARE = 2
}