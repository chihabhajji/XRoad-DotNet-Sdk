using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk;

/// <summary>
/// global configuration diagnostics
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class GlobalConfDiagnostics
{
    [JsonProperty("status_class", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public DiagnosticStatusClass Status_class { get; set; }

    [JsonProperty("status_code", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ConfigurationStatus Status_code { get; set; }

    /// <summary>
    /// last time updated
    /// </summary>
    [JsonProperty("prev_update_at", Required = Required.Always)]
    [Required]
    [StringLength(24, MinimumLength = 24)]
    public DateTimeOffset Prev_update_at { get; set; }

    /// <summary>
    /// last time updated
    /// </summary>
    [JsonProperty("next_update_at", Required = Required.Always)]
    [Required]
    [StringLength(24, MinimumLength = 24)]
    public DateTimeOffset Next_update_at { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}