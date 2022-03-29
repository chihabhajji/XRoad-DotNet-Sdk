# ChihabHajji.XRoad.Sdk.Model.CsrSubjectFieldDescription
object describing input fields for CSR subject DN info

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the identifier of the field (such as &#39;O&#39;, &#39;OU&#39; etc) | [readonly] 
**Label** | **string** | label of the field, used to display the field in the user interface | [optional] [readonly] 
**LabelKey** | **string** | localization key for label of the field, used to display the field in the user interface | [optional] [readonly] 
**DefaultValue** | **string** | the default value of the field. Can be empty. | [optional] [readonly] 
**ReadOnly** | **bool** | if this field is read-only | [readonly] 
**Required** | **bool** | if this field is required to be filled | [readonly] 
**Localized** | **bool** | if true, label key is in property \&quot;label_key\&quot;. If false, actual label is in property \&quot;label\&quot; | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

