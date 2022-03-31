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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace XRoad.Sdk.Model;

/// <summary>
/// Object for updating endpoints method and/or path
/// </summary>
[DataContract(Name = "EndpointUpdate")]
public class EndpointUpdate : IEquatable<EndpointUpdate>, IValidatableObject
{
    /// <summary>
    /// http method mapped to this endpoint
    /// </summary>
    /// <value>http method mapped to this endpoint</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MethodEnum
    {
        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")] Star = 1,

        /// <summary>
        /// Enum GET for value: GET
        /// </summary>
        [EnumMember(Value = "GET")] GET = 2,

        /// <summary>
        /// Enum POST for value: POST
        /// </summary>
        [EnumMember(Value = "POST")] POST = 3,

        /// <summary>
        /// Enum PUT for value: PUT
        /// </summary>
        [EnumMember(Value = "PUT")] PUT = 4,

        /// <summary>
        /// Enum DELETE for value: DELETE
        /// </summary>
        [EnumMember(Value = "DELETE")] DELETE = 5,

        /// <summary>
        /// Enum PATCH for value: PATCH
        /// </summary>
        [EnumMember(Value = "PATCH")] PATCH = 6,

        /// <summary>
        /// Enum HEAD for value: HEAD
        /// </summary>
        [EnumMember(Value = "HEAD")] HEAD = 7,

        /// <summary>
        /// Enum OPTIONS for value: OPTIONS
        /// </summary>
        [EnumMember(Value = "OPTIONS")] OPTIONS = 8,

        /// <summary>
        /// Enum TRACE for value: TRACE
        /// </summary>
        [EnumMember(Value = "TRACE")] TRACE = 9
    }


    /// <summary>
    /// http method mapped to this endpoint
    /// </summary>
    /// <value>http method mapped to this endpoint</value>
    [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = false)]
    public MethodEnum Method { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EndpointUpdate" /> class.
    /// </summary>
    [JsonConstructor]
    protected EndpointUpdate()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EndpointUpdate" /> class.
    /// </summary>
    /// <param name="method">http method mapped to this endpoint (required).</param>
    /// <param name="path">relative path where this endpoint is mapped to (required).</param>
    public EndpointUpdate(MethodEnum method = default, string path = default)
    {
        Method = method;
        // to ensure "path" is required (not null)
        Path = path ?? throw new ArgumentNullException(nameof(path),"path is a required property for EndpointUpdate and cannot be null");
    }

    /// <summary>
    /// relative path where this endpoint is mapped to
    /// </summary>
    /// <value>relative path where this endpoint is mapped to</value>
    [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
    public string Path { get; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EndpointUpdate {\n");
        sb.Append("  Method: ").Append(Method).Append('\n');
        sb.Append("  Path: ").Append(Path).Append('\n');
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
        return Equals(input as EndpointUpdate);
    }

    /// <summary>
    /// Returns true if EndpointUpdate instances are equal
    /// </summary>
    /// <param name="input">Instance of EndpointUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EndpointUpdate input)
    {
        if (input == null) return false;
        return
            (
                Method == input.Method ||
                Method.Equals(input.Method)
            ) &&
            (
                Path == input.Path ||
                (Path != null &&
                 Path.Equals(input.Path))
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            var hashCode = 41;
            hashCode = hashCode * 59 + Method.GetHashCode();
            if (Path != null) hashCode = hashCode * 59 + Path.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        yield break;
    }
}