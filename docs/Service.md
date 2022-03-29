# ChihabHajji.XRoad.Sdk.Model.Service
service for the service description

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | encoded service id, including client id | 
**FullServiceCode** | **string** | encoded service code and version | [optional] 
**ServiceCode** | **string** | encoded service code | 
**Timeout** | **int** | service time out value | 
**Title** | **string** | service title | [optional] [readonly] 
**SslAuth** | **bool** | service ssl auth | [optional] 
**SubjectsCount** | **int** | count of acl subjects | [optional] 
**Url** | **string** | service url | 
**Endpoints** | [**List&lt;Endpoint&gt;**](Endpoint.md) | list of endpoints linked to this service | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

