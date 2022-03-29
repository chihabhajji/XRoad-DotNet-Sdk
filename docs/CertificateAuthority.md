# ChihabHajji.XRoad.Sdk.Model.CertificateAuthority
approved certificate authority information. Only for top CAs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | name of the CA, as defined in global conf. Used also as an identifier | 
**SubjectDistinguishedName** | **string** | subject distinguished name | 
**IssuerDistinguishedName** | **string** | issuer distinguished name | 
**OcspResponse** | **CertificateAuthorityOcspResponse** |  | 
**NotAfter** | **DateTime** | certificate authority expires at | 
**TopCa** | **bool** | if the certificate authority is top CA (instead of intermediate) | 
**Path** | **string** | encoded path string from this CA to top CA | 
**AuthenticationOnly** | **bool** | if certificate authority is limited for authentication use only | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

