using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk;

/// <summary>
/// object describing input fields for CSR subject DN info
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class CsrSubjectFieldDescription
{
    /// <summary>
    /// the identifier of the field (such as 'O', 'OU' etc)
    /// </summary>
    [JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
    [Required]
    public string Id { get; set; }

    /// <summary>
    /// label of the field, used to display the field in the user interface
    /// </summary>
    [JsonProperty("label", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(int.MaxValue, MinimumLength = 1)]
    public string Label { get; set; }

    /// <summary>
    /// localization key for label of the field, used to display the field in the user interface
    /// </summary>
    [JsonProperty("label_key", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(int.MaxValue, MinimumLength = 1)]
    public string Label_key { get; set; }

    /// <summary>
    /// the default value of the field. Can be empty.
    /// </summary>
    [JsonProperty("default_value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(int.MaxValue)]
    public string Default_value { get; set; }

    /// <summary>
    /// if this field is read-only
    /// </summary>
    [JsonProperty("read_only", Required = Newtonsoft.Json.Required.Always)]
    public bool Read_only { get; set; }

    /// <summary>
    /// if this field is required to be filled
    /// </summary>
    [JsonProperty("required", Required = Newtonsoft.Json.Required.Always)]
    public bool Required { get; set; }

    /// <summary>
    /// if true, label key is in property "label_key". If false, actual label is in property "label"
    /// </summary>
    [JsonProperty("localized", Required = Newtonsoft.Json.Required.Always)]
    public bool Localized { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}