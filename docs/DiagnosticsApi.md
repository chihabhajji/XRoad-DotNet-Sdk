# ChihabHajji.XRoad.Sdk.Api.DiagnosticsApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGlobalConfDiagnostics**](DiagnosticsApi.md#getglobalconfdiagnostics) | **GET** /diagnostics/globalconf | view global configuration diagnostics information
[**GetOcspRespondersDiagnostics**](DiagnosticsApi.md#getocsprespondersdiagnostics) | **GET** /diagnostics/ocsp-responders | view ocsp responders diagnostics information
[**GetTimestampingServicesDiagnostics**](DiagnosticsApi.md#gettimestampingservicesdiagnostics) | **GET** /diagnostics/timestamping-services | view timestamping services diagnostics information


<a name="getglobalconfdiagnostics"></a>
# **GetGlobalConfDiagnostics**
> GlobalConfDiagnostics GetGlobalConfDiagnostics ()

view global configuration diagnostics information

<h3>Administrator views the global configuration diagnostics information.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetGlobalConfDiagnosticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DiagnosticsApi(config);

            try
            {
                // view global configuration diagnostics information
                GlobalConfDiagnostics result = apiInstance.GetGlobalConfDiagnostics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.GetGlobalConfDiagnostics: " + e.Message );
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

[**GlobalConfDiagnostics**](GlobalConfDiagnostics.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | global configuration diagnostics information |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getocsprespondersdiagnostics"></a>
# **GetOcspRespondersDiagnostics**
> List&lt;OcspResponderDiagnostics&gt; GetOcspRespondersDiagnostics ()

view ocsp responders diagnostics information

<h3>Administrator views the ocsp responders diagnostics information.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetOcspRespondersDiagnosticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DiagnosticsApi(config);

            try
            {
                // view ocsp responders diagnostics information
                List<OcspResponderDiagnostics> result = apiInstance.GetOcspRespondersDiagnostics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.GetOcspRespondersDiagnostics: " + e.Message );
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

[**List&lt;OcspResponderDiagnostics&gt;**](OcspResponderDiagnostics.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ocsp responders diagnostics information |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettimestampingservicesdiagnostics"></a>
# **GetTimestampingServicesDiagnostics**
> List&lt;TimestampingServiceDiagnostics&gt; GetTimestampingServicesDiagnostics ()

view timestamping services diagnostics information

<h3>Administrator views the timestamping services diagnostics information.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetTimestampingServicesDiagnosticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DiagnosticsApi(config);

            try
            {
                // view timestamping services diagnostics information
                List<TimestampingServiceDiagnostics> result = apiInstance.GetTimestampingServicesDiagnostics();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.GetTimestampingServicesDiagnostics: " + e.Message );
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

[**List&lt;TimestampingServiceDiagnostics&gt;**](TimestampingServiceDiagnostics.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | timestamping services diagnostics information |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

