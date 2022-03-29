# ChihabHajji.XRoad.Sdk.Model.ModelClient
x-road client

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;:&lt;subsystem&gt;(optional). Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters | [optional] [readonly] 
**InstanceId** | **string** | Xroad instance id. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters | [optional] [readonly] 
**MemberName** | **string** | Member name. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters | [optional] [readonly] 
**MemberClass** | **string** | Member class. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters | 
**MemberCode** | **string** | Member code. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters | 
**SubsystemCode** | **string** | Subsystem code. Cannot contain colons, semicolons, slashes, backslashes, percent signs or control characters | [optional] 
**Owner** | **bool** | if this client is the owner member of this security server | [optional] [readonly] 
**HasValidLocalSignCert** | **bool** | if this client has a valid (registered and with good OCSP response) sign cert stored on this security server | [optional] [readonly] 
**ConnectionType** | **ConnectionType** |  | [optional] 
**Status** | **ClientStatus** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

