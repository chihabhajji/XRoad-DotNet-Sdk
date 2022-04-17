using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace XRoad.Sdk;

/// <summary>
/// &lt;p&gt;The enum can have three different values&lt;/p&gt; &lt;ul&gt; &lt;li&gt;PRIMARY, which is the primary node in a high availability setup&lt;/li&gt; &lt;li&gt;SECONDARY, which is a secondary node in a high availability setup – a read-only server&lt;/li&gt; &lt;li&gt;STANDALONE,when there are no load balancer or high availability configured&lt;/li&gt; &lt;/ul&gt;
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public enum NodeType
{

    [EnumMember(Value = @"PRIMARY")]
    PRIMARY = 0,

    [EnumMember(Value = @"SECONDARY")]
    SECONDARY = 1,

    [EnumMember(Value = @"STANDALONE")]
    STANDALONE = 2,

}