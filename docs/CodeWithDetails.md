# ChihabHajji.XRoad.Sdk.Model.CodeWithDetails
object that contains a code identifier and possibly collection of associated metadata or validation errors. Used to relay error and warning information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | identifier of the item (for example errorcode) | 
**Metadata** | **List&lt;string&gt;** | array containing metadata associated with the item. For example names of services were attempted to add, but failed | [optional] 
**ValidationErrors** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | A dictionary object that contains validation errors bound to their respected fields. The key represents the field where the validation error has happened and the value is a list of validation errors | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

