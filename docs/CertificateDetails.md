# ChihabHajji.XRoad.Sdk.Model.CertificateDetails
certificate details for any kind of certificate (TLS, auth, sign)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IssuerDistinguishedName** | **string** | certificate issuer distinguished name | 
**IssuerCommonName** | **string** | certificate issuer common name | 
**SubjectDistinguishedName** | **string** | certificate subject distinguished name | 
**SubjectCommonName** | **string** | certificate subject common name | 
**NotBefore** | **DateTime** | certificate validity not before | 
**NotAfter** | **DateTime** | certificate validity not after | 
**Serial** | **string** | serial number | 
**_Version** | **int** | version | 
**SignatureAlgorithm** | **string** | certificate signature algorithm | 
**Signature** | **string** | hex encoded certificate signature | 
**PublicKeyAlgorithm** | **string** | certificate public key algorithm | 
**RsaPublicKeyModulus** | **string** | hex encoded RSA public key modulus (if RSA key) | 
**RsaPublicKeyExponent** | **int** | RSA public key exponent (if RSA key) as an integer | 
**Hash** | **string** | certificate SHA-1 hash | 
**KeyUsages** | [**List&lt;KeyUsage&gt;**](KeyUsage.md) | certificate key usage array | 
**SubjectAlternativeNames** | **string** | certificate subject alternative names | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

