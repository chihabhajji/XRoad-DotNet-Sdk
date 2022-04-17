using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk;

/// <summary>
/// x-road user
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class User
{
    /// <summary>
    /// user username
    /// </summary>
    [JsonProperty("username", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Username { get; set; }

    /// <summary>
    /// user roles
    /// </summary>
    [JsonProperty("roles", Required = Required.Always)]
    [Required]
    public ICollection<string> Roles { get; set; } = new Collection<string>();

    /// <summary>
    /// user permissions
    /// </summary>
    [JsonProperty("permissions", Required = Required.Always)]
    [Required]
    public ICollection<string> Permissions { get; set; } = new Collection<string>();

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}