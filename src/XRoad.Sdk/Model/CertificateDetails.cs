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
/// certificate details for any kind of certificate (TLS, auth, sign)
/// </summary>
[DataContract(Name = "CertificateDetails")]
public class CertificateDetails : IEquatable<CertificateDetails>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CertificateDetails" /> class.
    /// </summary>
    [JsonConstructor]
    protected CertificateDetails()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CertificateDetails" /> class.
    /// </summary>
    /// <param name="issuerDistinguishedName">certificate issuer distinguished name (required).</param>
    /// <param name="issuerCommonName">certificate issuer common name (required).</param>
    /// <param name="subjectDistinguishedName">certificate subject distinguished name (required).</param>
    /// <param name="subjectCommonName">certificate subject common name (required).</param>
    /// <param name="notBefore">certificate validity not before (required).</param>
    /// <param name="notAfter">certificate validity not after (required).</param>
    /// <param name="serial">serial number (required).</param>
    /// <param name="version">version (required).</param>
    /// <param name="signatureAlgorithm">certificate signature algorithm (required).</param>
    /// <param name="signature">hex encoded certificate signature (required).</param>
    /// <param name="publicKeyAlgorithm">certificate public key algorithm (required).</param>
    /// <param name="rsaPublicKeyModulus">hex encoded RSA public key modulus (if RSA key) (required).</param>
    /// <param name="rsaPublicKeyExponent">RSA public key exponent (if RSA key) as an integer (required).</param>
    /// <param name="hash">certificate SHA-1 hash (required).</param>
    /// <param name="keyUsages">certificate key usage array (required).</param>
    /// <param name="subjectAlternativeNames">certificate subject alternative names (required).</param>
    /// <exception cref="ArgumentNullException">Null parameter</exception>
    public CertificateDetails(string issuerDistinguishedName = default, string issuerCommonName = default,
        string subjectDistinguishedName = default, string subjectCommonName = default, DateTime notBefore = default,
        DateTime notAfter = default, string serial = default, int version = default,
        string signatureAlgorithm = default, string signature = default, string publicKeyAlgorithm = default,
        string rsaPublicKeyModulus = default, int rsaPublicKeyExponent = default, string hash = default,
        List<KeyUsage> keyUsages = default, string subjectAlternativeNames = default)
    {
        // to ensure "issuerDistinguishedName" is required (not null)
        IssuerDistinguishedName = issuerDistinguishedName ?? throw new ArgumentNullException(
            nameof(issuerDistinguishedName),
            "issuerDistinguishedName is a required property for CertificateDetails and cannot be null");
        // to ensure "issuerCommonName" is required (not null)
        IssuerCommonName = issuerCommonName ?? throw new ArgumentNullException(nameof(issuerCommonName),
            "issuerCommonName is a required property for CertificateDetails and cannot be null");
        // to ensure "subjectDistinguishedName" is required (not null)
        SubjectDistinguishedName = subjectDistinguishedName ?? throw new ArgumentNullException(
            nameof(subjectDistinguishedName),
            "subjectDistinguishedName is a required property for CertificateDetails and cannot be null");
        // to ensure "subjectCommonName" is required (not null)
        SubjectCommonName = subjectCommonName ?? throw new ArgumentNullException(nameof(subjectCommonName),
            "subjectCommonName is a required property for CertificateDetails and cannot be null");
        NotBefore = notBefore;
        NotAfter = notAfter;
        // to ensure "serial" is required (not null)
        Serial = serial ?? throw new ArgumentNullException(nameof(serial),
            "serial is a required property for CertificateDetails and cannot be null");
        Version = version;
        // to ensure "signatureAlgorithm" is required (not null)
        SignatureAlgorithm = signatureAlgorithm ?? throw new ArgumentNullException(nameof(signatureAlgorithm),
            "signatureAlgorithm is a required property for CertificateDetails and cannot be null");
        // to ensure "signature" is required (not null)
        Signature = signature ?? throw new ArgumentNullException(nameof(signature),
            "signature is a required property for CertificateDetails and cannot be null");
        // to ensure "publicKeyAlgorithm" is required (not null)
        PublicKeyAlgorithm = publicKeyAlgorithm ?? throw new ArgumentNullException(nameof(publicKeyAlgorithm),
            "publicKeyAlgorithm is a required property for CertificateDetails and cannot be null");
        // to ensure "rsaPublicKeyModulus" is required (not null)
        RsaPublicKeyModulus = rsaPublicKeyModulus ?? throw new ArgumentNullException(nameof(rsaPublicKeyModulus),
            "rsaPublicKeyModulus is a required property for CertificateDetails and cannot be null");
        RsaPublicKeyExponent = rsaPublicKeyExponent;
        // to ensure "hash" is required (not null)
        Hash = hash ?? throw new ArgumentNullException(nameof(hash),
            "hash is a required property for CertificateDetails and cannot be null");
        // to ensure "keyUsages" is required (not null)
        KeyUsages = keyUsages ?? throw new ArgumentNullException(nameof(keyUsages),
            "keyUsages is a required property for CertificateDetails and cannot be null");
        // to ensure "subjectAlternativeNames" is required (not null)
        SubjectAlternativeNames = subjectAlternativeNames ?? throw new ArgumentNullException(
            nameof(subjectAlternativeNames),
            "subjectAlternativeNames is a required property for CertificateDetails and cannot be null");
    }

    /// <summary>
    /// certificate issuer distinguished name
    /// </summary>
    /// <value>certificate issuer distinguished name</value>
    [DataMember(Name = "issuer_distinguished_name", IsRequired = true, EmitDefaultValue = false)]
    public string IssuerDistinguishedName { get; set; }

    /// <summary>
    /// certificate issuer common name
    /// </summary>
    /// <value>certificate issuer common name</value>
    [DataMember(Name = "issuer_common_name", IsRequired = true, EmitDefaultValue = false)]
    public string IssuerCommonName { get; set; }

    /// <summary>
    /// certificate subject distinguished name
    /// </summary>
    /// <value>certificate subject distinguished name</value>
    [DataMember(Name = "subject_distinguished_name", IsRequired = true, EmitDefaultValue = false)]
    public string SubjectDistinguishedName { get; set; }

    /// <summary>
    /// certificate subject common name
    /// </summary>
    /// <value>certificate subject common name</value>
    [DataMember(Name = "subject_common_name", IsRequired = true, EmitDefaultValue = false)]
    public string SubjectCommonName { get; set; }

    /// <summary>
    /// certificate validity not before
    /// </summary>
    /// <value>certificate validity not before</value>
    [DataMember(Name = "not_before", IsRequired = true, EmitDefaultValue = false)]
    public DateTime NotBefore { get; set; }

    /// <summary>
    /// certificate validity not after
    /// </summary>
    /// <value>certificate validity not after</value>
    [DataMember(Name = "not_after", IsRequired = true, EmitDefaultValue = false)]
    public DateTime NotAfter { get; set; }

    /// <summary>
    /// serial number
    /// </summary>
    /// <value>serial number</value>
    [DataMember(Name = "serial", IsRequired = true, EmitDefaultValue = false)]
    public string Serial { get; set; }

    /// <summary>
    /// version
    /// </summary>
    /// <value>version</value>
    [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
    public int Version { get; set; }

    /// <summary>
    /// certificate signature algorithm
    /// </summary>
    /// <value>certificate signature algorithm</value>
    [DataMember(Name = "signature_algorithm", IsRequired = true, EmitDefaultValue = false)]
    public string SignatureAlgorithm { get; set; }

    /// <summary>
    /// hex encoded certificate signature
    /// </summary>
    /// <value>hex encoded certificate signature</value>
    [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = false)]
    public string Signature { get; set; }

    /// <summary>
    /// certificate public key algorithm
    /// </summary>
    /// <value>certificate public key algorithm</value>
    [DataMember(Name = "public_key_algorithm", IsRequired = true, EmitDefaultValue = false)]
    public string PublicKeyAlgorithm { get; set; }

    /// <summary>
    /// hex encoded RSA public key modulus (if RSA key)
    /// </summary>
    /// <value>hex encoded RSA public key modulus (if RSA key)</value>
    [DataMember(Name = "rsa_public_key_modulus", IsRequired = true, EmitDefaultValue = false)]
    public string RsaPublicKeyModulus { get; set; }

    /// <summary>
    /// RSA public key exponent (if RSA key) as an integer
    /// </summary>
    /// <value>RSA public key exponent (if RSA key) as an integer</value>
    [DataMember(Name = "rsa_public_key_exponent", IsRequired = true, EmitDefaultValue = false)]
    public int RsaPublicKeyExponent { get; set; }

    /// <summary>
    /// certificate SHA-1 hash
    /// </summary>
    /// <value>certificate SHA-1 hash</value>
    [DataMember(Name = "hash", IsRequired = true, EmitDefaultValue = false)]
    public string Hash { get; set; }

    /// <summary>
    /// certificate key usage array
    /// </summary>
    /// <value>certificate key usage array</value>
    [DataMember(Name = "key_usages", IsRequired = true, EmitDefaultValue = false)]
    public List<KeyUsage> KeyUsages { get; set; }

    /// <summary>
    /// certificate subject alternative names
    /// </summary>
    /// <value>certificate subject alternative names</value>
    [DataMember(Name = "subject_alternative_names", IsRequired = true, EmitDefaultValue = false)]
    public string SubjectAlternativeNames { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CertificateDetails {\n");
        sb.Append("  IssuerDistinguishedName: ").Append(IssuerDistinguishedName).Append("\n");
        sb.Append("  IssuerCommonName: ").Append(IssuerCommonName).Append("\n");
        sb.Append("  SubjectDistinguishedName: ").Append(SubjectDistinguishedName).Append("\n");
        sb.Append("  SubjectCommonName: ").Append(SubjectCommonName).Append("\n");
        sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
        sb.Append("  NotAfter: ").Append(NotAfter).Append("\n");
        sb.Append("  Serial: ").Append(Serial).Append("\n");
        sb.Append("  _Version: ").Append(Version).Append("\n");
        sb.Append("  SignatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
        sb.Append("  Signature: ").Append(Signature).Append("\n");
        sb.Append("  PublicKeyAlgorithm: ").Append(PublicKeyAlgorithm).Append("\n");
        sb.Append("  RsaPublicKeyModulus: ").Append(RsaPublicKeyModulus).Append("\n");
        sb.Append("  RsaPublicKeyExponent: ").Append(RsaPublicKeyExponent).Append("\n");
        sb.Append("  Hash: ").Append(Hash).Append("\n");
        sb.Append("  KeyUsages: ").Append(KeyUsages).Append("\n");
        sb.Append("  SubjectAlternativeNames: ").Append(SubjectAlternativeNames).Append("\n");
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
        return Equals(input as CertificateDetails);
    }

    /// <summary>
    /// Returns true if CertificateDetails instances are equal
    /// </summary>
    /// <param name="input">Instance of CertificateDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CertificateDetails input)
    {
        if (input == null) return false;
        return
            (
                IssuerDistinguishedName == input.IssuerDistinguishedName ||
                (IssuerDistinguishedName != null &&
                 IssuerDistinguishedName.Equals(input.IssuerDistinguishedName))
            ) &&
            (
                IssuerCommonName == input.IssuerCommonName ||
                (IssuerCommonName != null &&
                 IssuerCommonName.Equals(input.IssuerCommonName))
            ) &&
            (
                SubjectDistinguishedName == input.SubjectDistinguishedName ||
                (SubjectDistinguishedName != null &&
                 SubjectDistinguishedName.Equals(input.SubjectDistinguishedName))
            ) &&
            (
                SubjectCommonName == input.SubjectCommonName ||
                (SubjectCommonName != null &&
                 SubjectCommonName.Equals(input.SubjectCommonName))
            ) &&
            (
                NotBefore == input.NotBefore ||
                NotBefore.Equals(input.NotBefore)
            ) &&
            (
                NotAfter == input.NotAfter ||
                NotAfter.Equals(input.NotAfter)
            ) &&
            (
                Serial == input.Serial ||
                (Serial != null &&
                 Serial.Equals(input.Serial))
            ) &&
            (
                Version == input.Version ||
                Version.Equals(input.Version)
            ) &&
            (
                SignatureAlgorithm == input.SignatureAlgorithm ||
                (SignatureAlgorithm != null &&
                 SignatureAlgorithm.Equals(input.SignatureAlgorithm))
            ) &&
            (
                Signature == input.Signature ||
                (Signature != null &&
                 Signature.Equals(input.Signature))
            ) &&
            (
                PublicKeyAlgorithm == input.PublicKeyAlgorithm ||
                (PublicKeyAlgorithm != null &&
                 PublicKeyAlgorithm.Equals(input.PublicKeyAlgorithm))
            ) &&
            (
                RsaPublicKeyModulus == input.RsaPublicKeyModulus ||
                (RsaPublicKeyModulus != null &&
                 RsaPublicKeyModulus.Equals(input.RsaPublicKeyModulus))
            ) &&
            (
                RsaPublicKeyExponent == input.RsaPublicKeyExponent ||
                RsaPublicKeyExponent.Equals(input.RsaPublicKeyExponent)
            ) &&
            (
                Hash == input.Hash ||
                (Hash != null &&
                 Hash.Equals(input.Hash))
            ) &&
            (
                KeyUsages == input.KeyUsages ||
                (KeyUsages != null &&
                 input.KeyUsages != null &&
                 KeyUsages.SequenceEqual(input.KeyUsages))
            ) &&
            (
                SubjectAlternativeNames == input.SubjectAlternativeNames ||
                (SubjectAlternativeNames != null &&
                 SubjectAlternativeNames.Equals(input.SubjectAlternativeNames))
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
            if (IssuerDistinguishedName != null) hashCode = hashCode * 59 + IssuerDistinguishedName.GetHashCode();
            if (IssuerCommonName != null) hashCode = hashCode * 59 + IssuerCommonName.GetHashCode();
            if (SubjectDistinguishedName != null) hashCode = hashCode * 59 + SubjectDistinguishedName.GetHashCode();
            if (SubjectCommonName != null) hashCode = hashCode * 59 + SubjectCommonName.GetHashCode();
            if (NotBefore != null) hashCode = hashCode * 59 + NotBefore.GetHashCode();
            if (NotAfter != null) hashCode = hashCode * 59 + NotAfter.GetHashCode();
            if (Serial != null) hashCode = hashCode * 59 + Serial.GetHashCode();
            hashCode = hashCode * 59 + Version.GetHashCode();
            if (SignatureAlgorithm != null) hashCode = hashCode * 59 + SignatureAlgorithm.GetHashCode();
            if (Signature != null) hashCode = hashCode * 59 + Signature.GetHashCode();
            if (PublicKeyAlgorithm != null) hashCode = hashCode * 59 + PublicKeyAlgorithm.GetHashCode();
            if (RsaPublicKeyModulus != null) hashCode = hashCode * 59 + RsaPublicKeyModulus.GetHashCode();
            hashCode = hashCode * 59 + RsaPublicKeyExponent.GetHashCode();
            if (Hash != null) hashCode = hashCode * 59 + Hash.GetHashCode();
            if (KeyUsages != null) hashCode = hashCode * 59 + KeyUsages.GetHashCode();
            if (SubjectAlternativeNames != null) hashCode = hashCode * 59 + SubjectAlternativeNames.GetHashCode();
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
        // IssuerDistinguishedName (string) maxLength
        if (IssuerDistinguishedName != null && IssuerDistinguishedName.Length > 255)
            yield return new ValidationResult(
                "Invalid value for IssuerDistinguishedName, length must be less than 255.",
                new[] {"IssuerDistinguishedName"});

        // IssuerDistinguishedName (string) minLength
        if (IssuerDistinguishedName != null && IssuerDistinguishedName.Length < 1)
            yield return new ValidationResult(
                "Invalid value for IssuerDistinguishedName, length must be greater than 1.",
                new[] {"IssuerDistinguishedName"});

        // IssuerCommonName (string) maxLength
        if (IssuerCommonName is {Length: > 255})
            yield return new ValidationResult("Invalid value for IssuerCommonName, length must be less than 255.",
                new[] {"IssuerCommonName"});

        // IssuerCommonName (string) minLength
        if (IssuerCommonName is {Length: < 1})
            yield return new ValidationResult("Invalid value for IssuerCommonName, length must be greater than 1.",
                new[] {"IssuerCommonName"});

        // SubjectDistinguishedName (string) maxLength
        if (SubjectDistinguishedName != null && SubjectDistinguishedName.Length > 255)
            yield return new ValidationResult(
                "Invalid value for SubjectDistinguishedName, length must be less than 255.",
                new[] {"SubjectDistinguishedName"});

        // SubjectDistinguishedName (string) minLength
        if (SubjectDistinguishedName != null && SubjectDistinguishedName.Length < 1)
            yield return new ValidationResult(
                "Invalid value for SubjectDistinguishedName, length must be greater than 1.",
                new[] {"SubjectDistinguishedName"});

        // SubjectCommonName (string) maxLength
        if (SubjectCommonName != null && SubjectCommonName.Length > 255)
            yield return new ValidationResult("Invalid value for SubjectCommonName, length must be less than 255.",
                new[] {"SubjectCommonName"});

        // SubjectCommonName (string) minLength
        if (SubjectCommonName != null && SubjectCommonName.Length < 1)
            yield return new ValidationResult("Invalid value for SubjectCommonName, length must be greater than 1.",
                new[] {"SubjectCommonName"});
        // TODO
        // // NotBefore (DateTime) maxLength
        // if (NotBefore != null && NotBefore.Length > 24)
        // {
        //     yield return new ValidationResult("Invalid value for NotBefore, length must be less than 24.", new [] { "NotBefore" });
        // }
        //
        // // NotBefore (DateTime) minLength
        // if (NotBefore != null && NotBefore.Length < 24)
        // {
        //     yield return new ValidationResult("Invalid value for NotBefore, length must be greater than 24.", new [] { "NotBefore" });
        // }
        //
        // // NotAfter (DateTime) maxLength
        // if (NotAfter != null && NotAfter.Length > 24)
        // {
        //     yield return new ValidationResult("Invalid value for NotAfter, length must be less than 24.", new [] { "NotAfter" });
        // }
        //
        // // NotAfter (DateTime) minLength
        // if (NotAfter != null && NotAfter.Length < 24)
        // {
        //     yield return new ValidationResult("Invalid value for NotAfter, length must be greater than 24.", new [] { "NotAfter" });
        // }

        // Serial (string) maxLength
        if (Serial != null && Serial.Length > 255)
            yield return new ValidationResult("Invalid value for Serial, length must be less than 255.",
                new[] {"Serial"});

        // Serial (string) minLength
        if (Serial != null && Serial.Length < 1)
            yield return new ValidationResult("Invalid value for Serial, length must be greater than 1.",
                new[] {"Serial"});

        // SignatureAlgorithm (string) maxLength
        if (SignatureAlgorithm != null && SignatureAlgorithm.Length > 255)
            yield return new ValidationResult("Invalid value for SignatureAlgorithm, length must be less than 255.",
                new[] {"SignatureAlgorithm"});

        // SignatureAlgorithm (string) minLength
        if (SignatureAlgorithm != null && SignatureAlgorithm.Length < 1)
            yield return new ValidationResult("Invalid value for SignatureAlgorithm, length must be greater than 1.",
                new[] {"SignatureAlgorithm"});

        // Signature (string) maxLength
        if (Signature != null && Signature.Length > 255)
            yield return new ValidationResult("Invalid value for Signature, length must be less than 255.",
                new[] {"Signature"});

        // Signature (string) minLength
        if (Signature != null && Signature.Length < 1)
            yield return new ValidationResult("Invalid value for Signature, length must be greater than 1.",
                new[] {"Signature"});

        // PublicKeyAlgorithm (string) maxLength
        if (PublicKeyAlgorithm != null && PublicKeyAlgorithm.Length > 255)
            yield return new ValidationResult("Invalid value for PublicKeyAlgorithm, length must be less than 255.",
                new[] {"PublicKeyAlgorithm"});

        // PublicKeyAlgorithm (string) minLength
        if (PublicKeyAlgorithm != null && PublicKeyAlgorithm.Length < 1)
            yield return new ValidationResult("Invalid value for PublicKeyAlgorithm, length must be greater than 1.",
                new[] {"PublicKeyAlgorithm"});

        // RsaPublicKeyModulus (string) maxLength
        if (RsaPublicKeyModulus != null && RsaPublicKeyModulus.Length > 1000)
            yield return new ValidationResult("Invalid value for RsaPublicKeyModulus, length must be less than 1000.",
                new[] {"RsaPublicKeyModulus"});

        // RsaPublicKeyModulus (string) minLength
        if (RsaPublicKeyModulus != null && RsaPublicKeyModulus.Length < 1)
            yield return new ValidationResult("Invalid value for RsaPublicKeyModulus, length must be greater than 1.",
                new[] {"RsaPublicKeyModulus"});

        // Hash (string) maxLength
        if (Hash != null && Hash.Length > 40)
            yield return new ValidationResult("Invalid value for Hash, length must be less than 40.", new[] {"Hash"});

        // Hash (string) minLength
        if (Hash != null && Hash.Length < 1)
            yield return new ValidationResult("Invalid value for Hash, length must be greater than 1.", new[] {"Hash"});

        // SubjectAlternativeNames (string) maxLength
        if (SubjectAlternativeNames != null && SubjectAlternativeNames.Length > 1000)
            yield return new ValidationResult(
                "Invalid value for SubjectAlternativeNames, length must be less than 1000.",
                new[] {"SubjectAlternativeNames"});

        // SubjectAlternativeNames (string) minLength
        if (SubjectAlternativeNames != null && SubjectAlternativeNames.Length < 1)
            yield return new ValidationResult(
                "Invalid value for SubjectAlternativeNames, length must be greater than 1.",
                new[] {"SubjectAlternativeNames"});
    }
}