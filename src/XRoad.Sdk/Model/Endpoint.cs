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
/// Endpoint for a service
/// </summary>
[DataContract(Name = "Endpoint")]
public class Endpoint : IEquatable<Endpoint>, IValidatableObject
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
        [EnumMember(Value = "*")] STAR = 1,

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
    /// Initializes a new instance of the <see cref="Endpoint" /> class.
    /// </summary>
    [JsonConstructor]
    protected Endpoint()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Endpoint" /> class.
    /// </summary>
    /// <param name="id">unique identifier.</param>
    /// <param name="serviceCode">serviceCode (required).</param>
    /// <param name="method">http method mapped to this endpoint (required).</param>
    /// <param name="path">relative path where this endpoint is mapped to (required).</param>
    public Endpoint(string id = default, string serviceCode = default, MethodEnum method = default,
        string path = default)
    {
        // to ensure "serviceCode" is required (not null)
        ServiceCode = serviceCode ?? throw new ArgumentNullException(nameof(serviceCode),"serviceCode is a required property for Endpoint and cannot be null");
        Method = method;
        // to ensure "path" is required (not null)
        Path = path ?? throw new ArgumentNullException(nameof(path),"path is a required property for Endpoint and cannot be null");
        Id = id;
    }

    /// <summary>
    /// unique identifier
    /// </summary>
    /// <value>unique identifier</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; }

    /// <summary>
    /// Gets or Sets ServiceCode
    /// </summary>
    [DataMember(Name = "service_code", IsRequired = true, EmitDefaultValue = false)]
    public string ServiceCode { get; }

    /// <summary>
    /// relative path where this endpoint is mapped to
    /// </summary>
    /// <value>relative path where this endpoint is mapped to</value>
    [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
    public string Path { get; }

    /// <summary>
    /// has endpoint been generated from openapi3 description
    /// </summary>
    /// <value>has endpoint been generated from openapi3 description</value>
    [DataMember(Name = "generated", EmitDefaultValue = true)]
    public bool Generated { get; }

    /// <summary>
    /// Returns false as Generated should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public bool ShouldSerializeGenerated()
    {
        return false;
    }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Endpoint {\n");
        sb.Append("  Id: ").Append(Id).Append('\n');
        sb.Append("  ServiceCode: ").Append(ServiceCode).Append('\n');
        sb.Append("  Method: ").Append(Method).Append('\n');
        sb.Append("  Path: ").Append(Path).Append('\n');
        sb.Append("  Generated: ").Append(Generated).Append('\n');
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
        return Equals(input as Endpoint);
    }

    /// <summary>
    /// Returns true if Endpoint instances are equal
    /// </summary>
    /// <param name="input">Instance of Endpoint to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Endpoint input)
    {
        if (input == null) return false;
        return
            (
                Id == input.Id ||
                (Id != null &&
                 Id.Equals(input.Id))
            ) &&
            (
                ServiceCode == input.ServiceCode ||
                (ServiceCode != null &&
                 ServiceCode.Equals(input.ServiceCode))
            ) &&
            (
                Method == input.Method ||
                Method.Equals(input.Method)
            ) &&
            (
                Path == input.Path ||
                (Path != null &&
                 Path.Equals(input.Path))
            ) &&
            (
                Generated == input.Generated ||
                Generated.Equals(input.Generated)
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
            if (Id != null) hashCode = hashCode * 59 + Id.GetHashCode();
            if (ServiceCode != null) hashCode = hashCode * 59 + ServiceCode.GetHashCode();
            hashCode = hashCode * 59 + Method.GetHashCode();
            if (Path != null) hashCode = hashCode * 59 + Path.GetHashCode();
            hashCode = hashCode * 59 + Generated.GetHashCode();
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