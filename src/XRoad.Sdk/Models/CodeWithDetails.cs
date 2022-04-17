using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// object that contains a code identifier and possibly collection of associated metadata or validation errors. Used to relay error and warning information.
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class CodeWithDetails
{
    /// <summary>
    /// identifier of the item (for example errorcode)
    /// </summary>
    [JsonProperty("code", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Code { get; set; }

    /// <summary>
    /// array containing metadata associated with the item. For example names of services were attempted to add, but failed
    /// </summary>
    [JsonProperty("metadata", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string> Metadata { get; set; }

    /// <summary>
    /// A dictionary object that contains validation errors bound to their respected fields. The key represents the field where the validation error has happened and the value is a list of validation errors
    /// </summary>
    [JsonProperty("validation_errors", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, ICollection<string>> Validation_errors { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}