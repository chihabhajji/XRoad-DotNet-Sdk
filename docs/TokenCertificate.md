# ChihabHajji.XRoad.Sdk.Model.TokenCertificate
Certificate that is stored in a Token (auth or sign cert). Also includes the possible actions that can be done to this object, e.g DELETE (only for cert related operations and does not consider user authorization).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OcspStatus** | **CertificateOcspStatus** |  | 
**OwnerId** | **string** | client id of the owner member, &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; | [readonly] 
**Active** | **bool** | if the certificate is active | 
**SavedToConfiguration** | **bool** | if the certificate is saved to configuration | 
**CertificateDetails** | [**CertificateDetails**](CertificateDetails.md) |  | 
**Status** | **CertificateStatus** |  | 
**PossibleActions** | [**List&lt;PossibleAction&gt;**](PossibleAction.md) | array containing the possible actions that can be done for this item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

