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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace XRoad.Sdk.Model;

/// <summary>
/// Token. Also includes the possible actions that can be done to this object, e.g DELETE (only for token related operations and does not consider user authorization).
/// </summary>
[DataContract(Name = "Token")]
public class Token : IEquatable<Token>, IValidatableObject
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
    public TokenType Type { get; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
    public TokenStatus Status { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Token" /> class.
    /// </summary>
    [JsonConstructor]
    protected Token()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Token" /> class.
    /// </summary>
    /// <param name="name">token name (required).</param>
    /// <param name="type">type (required).</param>
    /// <param name="keys">token keys (required).</param>
    /// <param name="status">status (required).</param>
    /// <param name="loggedIn">if the token has been logged in to (required).</param>
    /// <param name="available">if the token is available (required).</param>
    /// <param name="savedToConfiguration">if the token is saved to configuration (required).</param>
    /// <param name="readOnly">if the token is read-only (required).</param>
    /// <param name="serialNumber">serial number of the token.</param>
    /// <param name="tokenInfos">Contains label-value pairs of information.</param>
    /// <param name="possibleActions">array containing the possible actions that can be done for this item.</param>
    public Token(string name = default, TokenType type = default, List<Key> keys = default,
        TokenStatus status = default, bool loggedIn = default, bool available = default,
        bool savedToConfiguration = default, bool readOnly = default, string serialNumber = default,
        List<KeyValuePair> tokenInfos = default, List<PossibleAction> possibleActions = default)
    {
        // to ensure "name" is required (not null)
        Name = name ??
               throw new ArgumentNullException(nameof(name),
                   "name is a required property for Token and cannot be null");
        Type = type;
        // to ensure "keys" is required (not null)
        Keys = keys ??
               throw new ArgumentNullException(nameof(keys),
                   "keys is a required property for Token and cannot be null");
        Status = status;
        LoggedIn = loggedIn;
        Available = available;
        SavedToConfiguration = savedToConfiguration;
        ReadOnly = readOnly;
        SerialNumber = serialNumber;
        TokenInfos = tokenInfos;
        PossibleActions = possibleActions;
    }

    /// <summary>
    /// token id
    /// </summary>
    /// <value>token id</value>
    [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
    public string Id { get; }

    /// <summary>
    /// Returns false as Id should not be serialized given that it's read-only.
    /// </summary>
    /// <returns>false (boolean)</returns>
    public static bool ShouldSerializeId()
    {
        return false;
    }

    /// <summary>
    /// token name
    /// </summary>
    /// <value>token name</value>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
    public string Name { get; }

    /// <summary>
    /// token keys
    /// </summary>
    /// <value>token keys</value>
    [DataMember(Name = "keys", IsRequired = true, EmitDefaultValue = false)]
    public List<Key> Keys { get; }

    /// <summary>
    /// if the token has been logged in to
    /// </summary>
    /// <value>if the token has been logged in to</value>
    [DataMember(Name = "logged_in", IsRequired = true, EmitDefaultValue = true)]
    public bool LoggedIn { get; }

    /// <summary>
    /// if the token is available
    /// </summary>
    /// <value>if the token is available</value>
    [DataMember(Name = "available", IsRequired = true, EmitDefaultValue = true)]
    public bool Available { get; }

    /// <summary>
    /// if the token is saved to configuration
    /// </summary>
    /// <value>if the token is saved to configuration</value>
    [DataMember(Name = "saved_to_configuration", IsRequired = true, EmitDefaultValue = true)]
    public bool SavedToConfiguration { get; }

    /// <summary>
    /// if the token is read-only
    /// </summary>
    /// <value>if the token is read-only</value>
    [DataMember(Name = "read_only", IsRequired = true, EmitDefaultValue = true)]
    public bool ReadOnly { get; }

    /// <summary>
    /// serial number of the token
    /// </summary>
    /// <value>serial number of the token</value>
    [DataMember(Name = "serial_number", EmitDefaultValue = false)]
    public string SerialNumber { get; }

    /// <summary>
    /// Contains label-value pairs of information
    /// </summary>
    /// <value>Contains label-value pairs of information</value>
    [DataMember(Name = "token_infos", EmitDefaultValue = false)]
    public List<KeyValuePair> TokenInfos { get; }

    /// <summary>
    /// array containing the possible actions that can be done for this item
    /// </summary>
    /// <value>array containing the possible actions that can be done for this item</value>
    [DataMember(Name = "possible_actions", EmitDefaultValue = false)]
    public List<PossibleAction> PossibleActions { get; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Token {\n");
        sb.Append("  Id: ").Append(Id).Append('\n');
        sb.Append("  Name: ").Append(Name).Append('\n');
        sb.Append("  Type: ").Append(Type).Append('\n');
        sb.Append("  Keys: ").Append(Keys).Append('\n');
        sb.Append("  Status: ").Append(Status).Append('\n');
        sb.Append("  LoggedIn: ").Append(LoggedIn).Append('\n');
        sb.Append("  Available: ").Append(Available).Append('\n');
        sb.Append("  SavedToConfiguration: ").Append(SavedToConfiguration).Append('\n');
        sb.Append("  ReadOnly: ").Append(ReadOnly).Append('\n');
        sb.Append("  SerialNumber: ").Append(SerialNumber).Append('\n');
        sb.Append("  TokenInfos: ").Append(TokenInfos).Append('\n');
        sb.Append("  PossibleActions: ").Append(PossibleActions).Append('\n');
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
        return Equals(input as Token);
    }

    /// <summary>
    /// Returns true if Token instances are equal
    /// </summary>
    /// <param name="input">Instance of Token to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Token input)
    {
        if (input == null) return false;
        return
            (
                Id == input.Id ||
                (Id != null &&
                 Id.Equals(input.Id))
            ) &&
            (
                Name == input.Name ||
                (Name != null &&
                 Name.Equals(input.Name))
            ) &&
            (
                Type == input.Type ||
                Type.Equals(input.Type)
            ) &&
            (
                Keys == input.Keys ||
                (Keys != null &&
                 input.Keys != null &&
                 Keys.SequenceEqual(input.Keys))
            ) &&
            (
                Status == input.Status ||
                Status.Equals(input.Status)
            ) &&
            (
                LoggedIn == input.LoggedIn ||
                LoggedIn.Equals(input.LoggedIn)
            ) &&
            (
                Available == input.Available ||
                Available.Equals(input.Available)
            ) &&
            (
                SavedToConfiguration == input.SavedToConfiguration ||
                SavedToConfiguration.Equals(input.SavedToConfiguration)
            ) &&
            (
                ReadOnly == input.ReadOnly ||
                ReadOnly.Equals(input.ReadOnly)
            ) &&
            (
                SerialNumber == input.SerialNumber ||
                (SerialNumber != null &&
                 SerialNumber.Equals(input.SerialNumber))
            ) &&
            (
                TokenInfos == input.TokenInfos ||
                (TokenInfos != null &&
                 input.TokenInfos != null &&
                 TokenInfos.SequenceEqual(input.TokenInfos))
            ) &&
            (
                PossibleActions == input.PossibleActions ||
                (PossibleActions != null &&
                 input.PossibleActions != null &&
                 PossibleActions.SequenceEqual(input.PossibleActions))
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
            if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
            hashCode = hashCode * 59 + Type.GetHashCode();
            if (Keys != null) hashCode = hashCode * 59 + Keys.GetHashCode();
            hashCode = hashCode * 59 + Status.GetHashCode();
            hashCode = hashCode * 59 + LoggedIn.GetHashCode();
            hashCode = hashCode * 59 + Available.GetHashCode();
            hashCode = hashCode * 59 + SavedToConfiguration.GetHashCode();
            hashCode = hashCode * 59 + ReadOnly.GetHashCode();
            if (SerialNumber != null) hashCode = hashCode * 59 + SerialNumber.GetHashCode();
            if (TokenInfos != null) hashCode = hashCode * 59 + TokenInfos.GetHashCode();
            if (PossibleActions != null) hashCode = hashCode * 59 + PossibleActions.GetHashCode();
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
        // Id (string) minLength
        if (Id is {Length: < 1})
            yield return new ValidationResult("Invalid value for Id, length must be greater than 1.", new[] {"Id"});

        // Name (string) maxLength
        if (Name is {Length: > 255})
            yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new[] {"Name"});

        // Name (string) minLength
        if (Name is {Length: < 1})
            yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new[] {"Name"});
    }
}