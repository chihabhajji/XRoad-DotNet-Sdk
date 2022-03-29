# ChihabHajji.XRoad.Sdk.Model.Token
Token. Also includes the possible actions that can be done to this object, e.g DELETE (only for token related operations and does not consider user authorization).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | token id | [readonly] 
**Name** | **string** | token name | 
**Type** | **TokenType** |  | 
**Keys** | [**List&lt;Key&gt;**](Key.md) | token keys | 
**Status** | **TokenStatus** |  | 
**LoggedIn** | **bool** | if the token has been logged in to | 
**Available** | **bool** | if the token is available | 
**SavedToConfiguration** | **bool** | if the token is saved to configuration | 
**ReadOnly** | **bool** | if the token is read-only | 
**SerialNumber** | **string** | serial number of the token | [optional] 
**TokenInfos** | [**List&lt;KeyValuePair&gt;**](KeyValuePair.md) | Contains label-value pairs of information | [optional] 
**PossibleActions** | [**List&lt;PossibleAction&gt;**](PossibleAction.md) | array containing the possible actions that can be done for this item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

