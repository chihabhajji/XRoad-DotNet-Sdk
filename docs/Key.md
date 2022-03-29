# ChihabHajji.XRoad.Sdk.Model.Key
Key for the certificate. Also includes the possible actions that can be done to this object, e.g DELETE (only for key related operations and does not consider user authorization).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | key id | [readonly] 
**Name** | **string** | key name | 
**Label** | **string** | key label | 
**Certificates** | [**List&lt;TokenCertificate&gt;**](TokenCertificate.md) | list of certificates for the key | 
**CertificateSigningRequests** | [**List&lt;TokenCertificateSigningRequest&gt;**](TokenCertificateSigningRequest.md) | list of CSRs for the key | 
**Usage** | **KeyUsageType** |  | [optional] 
**Available** | **bool** | if the key is available | [optional] 
**SavedToConfiguration** | **bool** | if the key is saved to configuration | [optional] 
**PossibleActions** | [**List&lt;PossibleAction&gt;**](PossibleAction.md) | array containing the possible actions that can be done for this item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

