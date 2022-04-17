using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace XRoad.Sdk;

/// <summary>
/// version information
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class VersionInfo
{
    /// <summary>
    /// information about the security server
    /// </summary>
    [JsonProperty("info", Required = Required.Always)]
    [Required]
    [StringLength(255, MinimumLength = 1)]
    public string Info { get; set; }

    /// <summary>
    /// java version currently in use
    /// </summary>
    [JsonProperty("java_version", Required = Required.Always)]
    public int Java_version { get; set; }

    /// <summary>
    /// minimum supported java version
    /// </summary>
    [JsonProperty("min_java_version", Required = Required.Always)]
    public int Min_java_version { get; set; }

    /// <summary>
    /// maximum supported java version
    /// </summary>
    [JsonProperty("max_java_version", Required = Required.Always)]
    public int Max_java_version { get; set; }

    /// <summary>
    /// true if currently used java version is supported
    /// </summary>
    [JsonProperty("using_supported_java_version", Required = Required.Always)]
    public bool Using_supported_java_version { get; set; }

    /// <summary>
    /// java vendor string from java.vendor system property
    /// </summary>
    [JsonProperty("java_vendor", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Java_vendor { get; set; }

    /// <summary>
    /// java runtime version string from java.runtime.version system property
    /// </summary>
    [JsonProperty("java_runtime_version", Required = Required.Always)]
    [Required(AllowEmptyStrings = true)]
    public string Java_runtime_version { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}