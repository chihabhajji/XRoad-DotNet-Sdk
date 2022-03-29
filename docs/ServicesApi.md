# ChihabHajji.XRoad.Sdk.Api.ServicesApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEndpoint**](ServicesApi.md#addendpoint) | **POST** /services/{id}/endpoints | create endpoint
[**AddServiceServiceClients**](ServicesApi.md#addserviceserviceclients) | **POST** /services/{id}/service-clients | add access rights to selected service for new ServiceClients
[**DeleteServiceServiceClients**](ServicesApi.md#deleteserviceserviceclients) | **POST** /services/{id}/service-clients/delete | remove access to selected service from given ServiceClients
[**GetService**](ServicesApi.md#getservice) | **GET** /services/{id} | get service
[**GetServiceServiceClients**](ServicesApi.md#getserviceserviceclients) | **GET** /services/{id}/service-clients | get service clients who have access rights for the selected service
[**UpdateService**](ServicesApi.md#updateservice) | **PATCH** /services/{id} | update service


<a name="addendpoint"></a>
# **AddEndpoint**
> Endpoint AddEndpoint (string id, Endpoint endpoint = null)

create endpoint

<h3>Administrator creates a new endpoint.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddEndpointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(config);
            var id = CS:ORG:Client:myService.v1;  // string | id of the service
            var endpoint = new Endpoint(); // Endpoint |  (optional) 

            try
            {
                // create endpoint
                Endpoint result = apiInstance.AddEndpoint(id, endpoint);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.AddEndpoint: " + e.Message );
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
 **id** | **string**| id of the service | 
 **endpoint** | [**Endpoint**](Endpoint.md)|  | [optional] 

### Return type

[**Endpoint**](Endpoint.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | endpoint added |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addserviceserviceclients"></a>
# **AddServiceServiceClients**
> List&lt;ServiceClient&gt; AddServiceServiceClients (string id, ServiceClients serviceClients = null)

add access rights to selected service for new ServiceClients

<h3>Adds access rights to selected service for new ServiceClients.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddServiceServiceClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(config);
            var id = "id_example";  // string | id of the service
            var serviceClients = new ServiceClients(); // ServiceClients |  (optional) 

            try
            {
                // add access rights to selected service for new ServiceClients
                List<ServiceClient> result = apiInstance.AddServiceServiceClients(id, serviceClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.AddServiceServiceClients: " + e.Message );
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
 **id** | **string**| id of the service | 
 **serviceClients** | [**ServiceClients**](ServiceClients.md)|  | [optional] 

### Return type

[**List&lt;ServiceClient&gt;**](ServiceClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | access rights added |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteserviceserviceclients"></a>
# **DeleteServiceServiceClients**
> void DeleteServiceServiceClients (string id, ServiceClients serviceClients = null)

remove access to selected service from given ServiceClients

<h3>Administrator removes access to selected service from given ServiceClients.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteServiceServiceClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(config);
            var id = "id_example";  // string | id of the service
            var serviceClients = new ServiceClients(); // ServiceClients |  (optional) 

            try
            {
                // remove access to selected service from given ServiceClients
                apiInstance.DeleteServiceServiceClients(id, serviceClients);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.DeleteServiceServiceClients: " + e.Message );
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
 **id** | **string**| id of the service | 
 **serviceClients** | [**ServiceClients**](ServiceClients.md)|  | [optional] 

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
| **204** | access right(s) deletion was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservice"></a>
# **GetService**
> Service GetService (string id)

get service

<h3>Administrator views selected service.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(config);
            var id = CS:ORG:Client:myService.v1;  // string | id of the service

            try
            {
                // get service
                Service result = apiInstance.GetService(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetService: " + e.Message );
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
 **id** | **string**| id of the service | 

### Return type

[**Service**](Service.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ok |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceserviceclients"></a>
# **GetServiceServiceClients**
> List&lt;ServiceClient&gt; GetServiceServiceClients (string id)

get service clients who have access rights for the selected service

<h3>Administrator views service clients who have access to the given service.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetServiceServiceClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(config);
            var id = CS:ORG:Client:myService.v1;  // string | id of the service

            try
            {
                // get service clients who have access rights for the selected service
                List<ServiceClient> result = apiInstance.GetServiceServiceClients(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.GetServiceServiceClients: " + e.Message );
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
 **id** | **string**| id of the service | 

### Return type

[**List&lt;ServiceClient&gt;**](ServiceClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of service clients |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateservice"></a>
# **UpdateService**
> Service UpdateService (string id, ServiceUpdate serviceUpdate = null)

update service

<h3>Administrator updates the service.</h3> <p> This endpoint can return a warnings response which can be ignored by setting <code>ServiceUpdate.ignore_warnings</code> = true. If <code>ServiceUpdate.ignore_warnings</code> = false, it is possible to receive a warnings response from this endpoint if any one of the following conditions is true <ul> <li>SSL authentication is set to true, but https connection to the service URL fails because SSL handshake fails</li> <li>SSL authentication is set to true, but https connection to the service URL fails because of other errors (e.g. host unreachable)</li> </ul> </p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UpdateServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServicesApi(config);
            var id = CS:ORG:Client:myService.v1;  // string | id of the service
            var serviceUpdate = new ServiceUpdate(); // ServiceUpdate |  (optional) 

            try
            {
                // update service
                Service result = apiInstance.UpdateService(id, serviceUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesApi.UpdateService: " + e.Message );
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
 **id** | **string**| id of the service | 
 **serviceUpdate** | [**ServiceUpdate**](ServiceUpdate.md)|  | [optional] 

### Return type

[**Service**](Service.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | service modified |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

