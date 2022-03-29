# ChihabHajji.XRoad.Sdk.Api.OpenapiApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadOpenApi**](OpenapiApi.md#downloadopenapi) | **GET** /openapi.yaml | download security server&#39;s openapi definition


<a name="downloadopenapi"></a>
# **DownloadOpenApi**
> System.IO.Stream DownloadOpenApi ()

download security server's openapi definition

<h3>Administrator downloads the security server's OpenAPI definition.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DownloadOpenApiExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OpenapiApi(config);

            try
            {
                // download security server's openapi definition
                System.IO.Stream result = apiInstance.DownloadOpenApi();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpenapiApi.DownloadOpenApi: " + e.Message );
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

**System.IO.Stream**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/x-yaml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | openapi definition |  -  |
| **400** | request was invalid |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

