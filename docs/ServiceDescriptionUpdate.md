# ChihabHajji.XRoad.Sdk.Model.ServiceDescriptionUpdate
request object for updating a service description url or service code

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | path for the service description file | 
**RestServiceCode** | **string** | service code for REST service | [optional] 
**NewRestServiceCode** | **string** | new service code for REST service | [optional] 
**IgnoreWarnings** | **bool** | if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail | [optional] [default to false]
**Type** | **ServiceType** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

