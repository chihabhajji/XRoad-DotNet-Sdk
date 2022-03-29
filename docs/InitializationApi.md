# ChihabHajji.XRoad.Sdk.Api.InitializationApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInitializationStatus**](InitializationApi.md#getinitializationstatus) | **GET** /initialization/status | Check the initialization status of the Security Server
[**InitSecurityServer**](InitializationApi.md#initsecurityserver) | **POST** /initialization | Initialize a new security server with the provided initial configuration


<a name="getinitializationstatus"></a>
# **GetInitializationStatus**
> InitializationStatus GetInitializationStatus ()

Check the initialization status of the Security Server

<h3>Administrator checks the initialization status of the Security Server.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetInitializationStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InitializationApi(config);

            try
            {
                // Check the initialization status of the Security Server
                InitializationStatus result = apiInstance.GetInitializationStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InitializationApi.GetInitializationStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InitializationStatus**](InitializationStatus.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | initialization status of the Security Server |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initsecurityserver"></a>
# **InitSecurityServer**
> void InitSecurityServer (InitialServerConf initialServerConf = null)

Initialize a new security server with the provided initial configuration

<h3>Administrator initializes a new Security Server with the provided initial configuration.</h3> <p> This endpoint can also return metadata in the error response. The metadata array can contain error messages about why the init did not succeed. If the pin code is too weak, the error code <code>weak_pin</code> is used and the entries in the metadata array are always ordered in following way <ul> <li>metadata has a list of strings [\"pin_min_length\", x, \"pin_min_char_classes_count\", y] where</li> <li>x = the minimum length of the pin code</li> <li>y = the minimum amount of character classes (e.g. uppercase, number, special characters) to be used in the pin code</li> </ul> Other possible error code is <code>invalid_init_params</code> which can have any one or more of the following strings in the metadata field <ul> <li>server_code_not_provided</li> <li>member_class_not_provided</li> <li>member_code_not_provided</li> <li>pin_code_not_provided</li> <li>server_code_exists</li> <li>member_class_exists</li> <li>member_code_exists</li> <li>pin_code_exists</li> </ul> </p> <p> This endpoint can return a warnings response which can be ignored by setting <code>InitialServerConf.ignore_warnings</code> = true. If <code>InitialServerConf.ignore_warnings</code> = false, a warnings response will be returned if any one of the following conditions is true <ul> <li>server code has already been set for this Security Server (warning code <code>init_servercode_exists</code>)</li> <li>server owner has already been set for this Security Server(warning code <code>init_server_owner_exists</code>)</li> <li>software token has already been initialized in this Security Server(warning code <code>init_software_token_initialized</code>)</li> <li>the provided owner member is unregistered(warning code <code>init_unregistered_member</code>)</li> <li>the provided server id is already in use by another Security Server(warning code <code>init_server_id_exists</code>)</li> </ul> </p> <strong>See the '400' response examples</strong>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class InitSecurityServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InitializationApi(config);
            var initialServerConf = new InitialServerConf(); // InitialServerConf | initial security server configuration (optional) 

            try
            {
                // Initialize a new security server with the provided initial configuration
                apiInstance.InitSecurityServer(initialServerConf);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InitializationApi.InitSecurityServer: " + e.Message );
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
 **initialServerConf** | [**InitialServerConf**](InitialServerConf.md)| initial security server configuration | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | security server initialized |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

