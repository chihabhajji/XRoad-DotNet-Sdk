# ChihabHajji.XRoad.Sdk.Model.TokenCertificateSigningRequest
CSR for certificate that is stored in a Token. Also includes the possible actions that can be done to this object, e.g DELETE (only for csr related operations and does not consider user authorization).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | CSR id | [readonly] 
**OwnerId** | **string** | client id of the owner member, &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; | [readonly] 
**PossibleActions** | [**List&lt;PossibleAction&gt;**](PossibleAction.md) | array containing the possible actions that can be done for this item | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

