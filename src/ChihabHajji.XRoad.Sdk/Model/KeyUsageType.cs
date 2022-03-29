/*
 * X-Road Security Server Admin API
 *
 * X-Road Security Server Admin API. Note that the error metadata responses described in some endpoints are subjects to change and may be updated in upcoming versions.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: info@niis.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ChihabHajji.XRoad.Sdk.Client.OpenAPIDateConverter;

namespace ChihabHajji.XRoad.Sdk.Model
{
    /// <summary>
    /// intended usage for the key (signing or authentication)
    /// </summary>
    /// <value>intended usage for the key (signing or authentication)</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KeyUsageType
    {
        /// <summary>
        /// Enum AUTHENTICATION for value: AUTHENTICATION
        /// </summary>
        [EnumMember(Value = "AUTHENTICATION")]
        AUTHENTICATION = 1,

        /// <summary>
        /// Enum SIGNING for value: SIGNING
        /// </summary>
        [EnumMember(Value = "SIGNING")]
        SIGNING = 2

    }

}