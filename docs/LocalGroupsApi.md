# ChihabHajji.XRoad.Sdk.Api.LocalGroupsApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLocalGroupMember**](LocalGroupsApi.md#addlocalgroupmember) | **POST** /local-groups/{group_id}/members | add new member for the local group
[**DeleteLocalGroup**](LocalGroupsApi.md#deletelocalgroup) | **DELETE** /local-groups/{group_id} | delete local group
[**DeleteLocalGroupMember**](LocalGroupsApi.md#deletelocalgroupmember) | **POST** /local-groups/{group_id}/members/delete | delete member from local group
[**GetLocalGroup**](LocalGroupsApi.md#getlocalgroup) | **GET** /local-groups/{group_id} | get local group information
[**UpdateLocalGroup**](LocalGroupsApi.md#updatelocalgroup) | **PATCH** /local-groups/{group_id} | update local group information


<a name="addlocalgroupmember"></a>
# **AddLocalGroupMember**
> Members AddLocalGroupMember (string groupId, Members members = null)

add new member for the local group

<h3>Administrator adds a new member for the local group.</h3> <p>The new member can be an X-Road member or a subsystem.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddLocalGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LocalGroupsApi(config);
            var groupId = "groupId_example";  // string | id of the local group
            var members = new Members(); // Members |  (optional) 

            try
            {
                // add new member for the local group
                Members result = apiInstance.AddLocalGroupMember(groupId, members);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalGroupsApi.AddLocalGroupMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| id of the local group | 
 **members** | [**Members**](Members.md)|  | [optional] 

### Return type

[**Members**](Members.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | new members added |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocalgroup"></a>
# **DeleteLocalGroup**
> void DeleteLocalGroup (string groupId)

delete local group

<h3>Administrator deletes the local group.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteLocalGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LocalGroupsApi(config);
            var groupId = "groupId_example";  // string | id of the local group

            try
            {
                // delete local group
                apiInstance.DeleteLocalGroup(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalGroupsApi.DeleteLocalGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| id of the local group | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | local group deletion was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocalgroupmember"></a>
# **DeleteLocalGroupMember**
> void DeleteLocalGroupMember (string groupId, Members members = null)

delete member from local group

<h3>Administrator deletes the member from local group.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteLocalGroupMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LocalGroupsApi(config);
            var groupId = "groupId_example";  // string | id of the local group
            var members = new Members(); // Members |  (optional) 

            try
            {
                // delete member from local group
                apiInstance.DeleteLocalGroupMember(groupId, members);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalGroupsApi.DeleteLocalGroupMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| id of the local group | 
 **members** | [**Members**](Members.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | members deleted |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocalgroup"></a>
# **GetLocalGroup**
> LocalGroup GetLocalGroup (string groupId)

get local group information

<h3>Administrator views local group details.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetLocalGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LocalGroupsApi(config);
            var groupId = "groupId_example";  // string | id of the local group

            try
            {
                // get local group information
                LocalGroup result = apiInstance.GetLocalGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalGroupsApi.GetLocalGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| id of the local group | 

### Return type

[**LocalGroup**](LocalGroup.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | group object |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelocalgroup"></a>
# **UpdateLocalGroup**
> LocalGroup UpdateLocalGroup (string groupId, LocalGroupDescription localGroupDescription = null)

update local group information

<h3>Administrator updates the local group information.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UpdateLocalGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LocalGroupsApi(config);
            var groupId = "groupId_example";  // string | id of the local group
            var localGroupDescription = new LocalGroupDescription(); // LocalGroupDescription |  (optional) 

            try
            {
                // update local group information
                LocalGroup result = apiInstance.UpdateLocalGroup(groupId, localGroupDescription);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocalGroupsApi.UpdateLocalGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| id of the local group | 
 **localGroupDescription** | [**LocalGroupDescription**](LocalGroupDescription.md)|  | [optional] 

### Return type

[**LocalGroup**](LocalGroup.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | local group modified |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

