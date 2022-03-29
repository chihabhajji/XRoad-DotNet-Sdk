# ChihabHajji.XRoad.Sdk.Api.KeysApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCsr**](KeysApi.md#deletecsr) | **DELETE** /keys/{id}/csrs/{csr_id} | delete csr from the selected key
[**DeleteKey**](KeysApi.md#deletekey) | **DELETE** /keys/{id} | delete key
[**DownloadCsr**](KeysApi.md#downloadcsr) | **GET** /keys/{id}/csrs/{csr_id} | download a CSR binary
[**GenerateCsr**](KeysApi.md#generatecsr) | **POST** /keys/{id}/csrs | generate csr for the selected key
[**GetKey**](KeysApi.md#getkey) | **GET** /keys/{id} | get information for the selected key in selected token
[**GetPossibleActionsForCsr**](KeysApi.md#getpossibleactionsforcsr) | **GET** /keys/{id}/csrs/{csr_id}/possible-actions | get possible actions for one csr
[**GetPossibleActionsForKey**](KeysApi.md#getpossibleactionsforkey) | **GET** /keys/{id}/possible-actions | get possible actions for one key
[**UpdateKey**](KeysApi.md#updatekey) | **PATCH** /keys/{id} | update key information


<a name="deletecsr"></a>
# **DeleteCsr**
> void DeleteCsr (string id, string csrId)

delete csr from the selected key

<h3>Administrator deletes csr from the key.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteCsrExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi(config);
            var id = "id_example";  // string | id of the key
            var csrId = "csrId_example";  // string | id of the csr

            try
            {
                // delete csr from the selected key
                apiInstance.DeleteCsr(id, csrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeysApi.DeleteCsr: " + e.Message );
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
 **id** | **string**| id of the key | 
 **csrId** | **string**| id of the csr | 

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
| **204** | csr deletion was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletekey"></a>
# **DeleteKey**
> void DeleteKey (string id, bool? ignoreWarnings = null)

delete key

<h3>Administrator deletes the key.</h3> <p>This endpoint can also return metadata in the error response if sending an auth cert deletion management request fails. The metadata array contains the error details that were generated in core. The message is in plain English.</p> <p> Note that with this endpoint it's possible to delete an authentication key with a registered authentication certificate. <ul> <li>Attempt to delete an authentication key with a registered authentication certificate and with <code>ignore_warnings</code> = false causes the operation to fail with a warning in response's ErrorInfo object.</li> <li>Attempt to delete an authentication key with a registered authentication certificate and with <code>ignore_warnings</code> = true succeeds. The authentication certificate is first unregistered, and the key and certificate are deleted after that.</li> </ul> <p>When trying to delete an authentication key with a registered authentication certificate, the warning response has a warning code <code>auth_key_with_registered_cert_warning</code> and the metadata field contains the key id of the key</p> </p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi(config);
            var id = "id_example";  // string | id of the key
            var ignoreWarnings = false;  // bool? | if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail (optional)  (default to false)

            try
            {
                // delete key
                apiInstance.DeleteKey(id, ignoreWarnings);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeysApi.DeleteKey: " + e.Message );
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
 **id** | **string**| id of the key | 
 **ignoreWarnings** | **bool?**| if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | key deletion was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadcsr"></a>
# **DownloadCsr**
> System.IO.Stream DownloadCsr (string id, string csrId, CsrFormat? csrFormat = null)

download a CSR binary

<h3>Administrator downloads a csr that has been created earlier.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DownloadCsrExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi(config);
            var id = "id_example";  // string | id of the key
            var csrId = "csrId_example";  // string | id of the csr
            var csrFormat = (CsrFormat) "PEM";  // CsrFormat? | format of the certificate signing request (PEM or DER) (optional) 

            try
            {
                // download a CSR binary
                System.IO.Stream result = apiInstance.DownloadCsr(id, csrId, csrFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeysApi.DownloadCsr: " + e.Message );
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
 **id** | **string**| id of the key | 
 **csrId** | **string**| id of the csr | 
 **csrFormat** | **CsrFormat?**| format of the certificate signing request (PEM or DER) | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | CSR binary |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatecsr"></a>
# **GenerateCsr**
> System.IO.Stream GenerateCsr (string id, CsrGenerate csrGenerate = null)

generate csr for the selected key

<h3>Administrator generates csr for the key.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GenerateCsrExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi(config);
            var id = "id_example";  // string | id of the key
            var csrGenerate = new CsrGenerate(); // CsrGenerate | request to generate csr (optional) 

            try
            {
                // generate csr for the selected key
                System.IO.Stream result = apiInstance.GenerateCsr(id, csrGenerate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeysApi.GenerateCsr: " + e.Message );
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
 **id** | **string**| id of the key | 
 **csrGenerate** | [**CsrGenerate**](CsrGenerate.md)| request to generate csr | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | created CSR |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkey"></a>
# **GetKey**
> Key GetKey (string id)

get information for the selected key in selected token

<h3>Administrator views key details.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi(config);
            var id = "id_example";  // string | id of the key

            try
            {
                // get information for the selected key in selected token
                Key result = apiInstance.GetKey(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeysApi.GetKey: " + e.Message );
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
 **id** | **string**| id of the key | 

### Return type

[**Key**](Key.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | key object |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpossibleactionsforcsr"></a>
# **GetPossibleActionsForCsr**
> List&lt;PossibleAction&gt; GetPossibleActionsForCsr (string id, string csrId)

get possible actions for one csr

<h3>UI needs to know which actions can be done on one csr.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetPossibleActionsForCsrExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi(config);
            var id = "id_example";  // string | id of the key
            var csrId = "csrId_example";  // string | id of the csr

            try
            {
                // get possible actions for one csr
                List<PossibleAction> result = apiInstance.GetPossibleActionsForCsr(id, csrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeysApi.GetPossibleActionsForCsr: " + e.Message );
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
 **id** | **string**| id of the key | 
 **csrId** | **string**| id of the csr | 

### Return type

[**List&lt;PossibleAction&gt;**](PossibleAction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | possible actions that can be done on the certificate |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpossibleactionsforkey"></a>
# **GetPossibleActionsForKey**
> List&lt;PossibleAction&gt; GetPossibleActionsForKey (string id)

get possible actions for one key

<h3>UI needs to know which actions can be done on one key.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetPossibleActionsForKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi(config);
            var id = "id_example";  // string | id of the key

            try
            {
                // get possible actions for one key
                List<PossibleAction> result = apiInstance.GetPossibleActionsForKey(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeysApi.GetPossibleActionsForKey: " + e.Message );
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
 **id** | **string**| id of the key | 

### Return type

[**List&lt;PossibleAction&gt;**](PossibleAction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | possible actions that can be done on the certificate |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatekey"></a>
# **UpdateKey**
> Key UpdateKey (string id, KeyName keyName = null)

update key information

<h3>Administrator updates the key information.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UpdateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KeysApi(config);
            var id = "id_example";  // string | id of the key
            var keyName = new KeyName(); // KeyName |  (optional) 

            try
            {
                // update key information
                Key result = apiInstance.UpdateKey(id, keyName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KeysApi.UpdateKey: " + e.Message );
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
 **id** | **string**| id of the key | 
 **keyName** | [**KeyName**](KeyName.md)|  | [optional] 

### Return type

[**Key**](Key.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | key modified |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

