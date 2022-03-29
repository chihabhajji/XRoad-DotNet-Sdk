# ChihabHajji.XRoad.Sdk.Model.ServiceClient
service client. May be a subsystem, local group, or a global group

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | subject id - can be a subsystem id &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;:&lt;subsystem&gt; | globalgroup id &lt;instance_id&gt;:&lt;group_code&gt; | localgroup resource id in number format &lt;id&gt; | 
**Name** | **string** | name of the ServiceClient - can be the name of a member or the description of a group | [optional] [readonly] 
**LocalGroupCode** | **string** | group code in case the object is a local group | [optional] [readonly] 
**ServiceClientType** | **ServiceClientType** |  | [optional] 
**RightsGivenAt** | **DateTime** | time when access right were given at. When listing client&#39;s service clients without specifying the service, the time when first service access right was given to this service client for any service. When listing service clients for a specific service, time when service client was added permission to that service. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

