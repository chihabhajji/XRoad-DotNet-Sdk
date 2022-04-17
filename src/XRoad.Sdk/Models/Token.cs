using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk.Models;

/// <summary>
/// Token. Also includes the possible actions that can be done to this object, e.g DELETE (only for token related operations and does not consider user authorization).
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class Token
{
    /// <summary>
    /// token id
    /// </summary>
    [JsonProperty("id", Required = Required.Always)]
    [Required]
    public string Id { get; set; }

    /// <summary>
    /// token name
    /// </summary>
    [JsonProperty("name", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Name { get; set; }

    [JsonProperty("type", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public TokenType Type { get; set; }

    /// <summary>
    /// token keys
    /// </summary>
    [JsonProperty("keys", Required = Required.Always)]
    [Required]
    public ICollection<Key> Keys { get; set; } = new Collection<Key>();

    [JsonProperty("status", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    [JsonConverter(typeof(StringEnumConverter))]
    public TokenStatus Status { get; set; }

    /// <summary>
    /// if the token has been logged in to
    /// </summary>
    [JsonProperty("logged_in", Required = Required.Always)]
    public bool Logged_in { get; set; }

    /// <summary>
    /// if the token is available
    /// </summary>
    [JsonProperty("available", Required = Required.Always)]
    public bool Available { get; set; }

    /// <summary>
    /// if the token is saved to configuration
    /// </summary>
    [JsonProperty("saved_to_configuration", Required = Required.Always)]
    public bool Saved_to_configuration { get; set; }

    /// <summary>
    /// if the token is read-only
    /// </summary>
    [JsonProperty("read_only", Required = Required.Always)]
    public bool Read_only { get; set; }

    /// <summary>
    /// serial number of the token
    /// </summary>
    [JsonProperty("serial_number", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public string Serial_number { get; set; }

    /// <summary>
    /// Contains label-value pairs of information
    /// </summary>
    [JsonProperty("token_infos", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<KeyValuePair> Token_infos { get; set; }

    [JsonProperty("possible_actions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore,
        ItemConverterType = typeof(StringEnumConverter))]
    public PossibleActions Possible_actions { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}