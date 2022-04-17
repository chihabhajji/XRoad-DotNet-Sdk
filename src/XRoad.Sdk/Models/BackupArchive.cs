using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XRoad.Sdk.Models;

/// <summary>
/// security server backup archive file
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class BackupArchive
{
    [JsonProperty("file", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
    public byte[] File { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }
}