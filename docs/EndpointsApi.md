# ChihabHajji.XRoad.Sdk.Api.EndpointsApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEndpointServiceClients**](EndpointsApi.md#addendpointserviceclients) | **POST** /endpoints/{id}/service-clients | add access rights for given service clients to the selected endpoint
[**DeleteEndpoint**](EndpointsApi.md#deleteendpoint) | **DELETE** /endpoints/{id} | delete endpoint
[**DeleteEndpointServiceClients**](EndpointsApi.md#deleteendpointserviceclients) | **POST** /endpoints/{id}/service-clients/delete | remove access rights from specified service clients to the selected endpoint
[**GetEndpoint**](EndpointsApi.md#getendpoint) | **GET** /endpoints/{id} | Get an endpoint by its id
[**GetEndpointServiceClients**](EndpointsApi.md#getendpointserviceclients) | **GET** /endpoints/{id}/service-clients | get service clients who have access rights for the selected endpoint
[**UpdateEndpoint**](EndpointsApi.md#updateendpoint) | **PATCH** /endpoints/{id} | Update an endpoint


<a name="addendpointserviceclients"></a>
# **AddEndpointServiceClients**
> List&lt;ServiceClient&gt; AddEndpointServiceClients (string id, ServiceClients serviceClients = null)

add access rights for given service clients to the selected endpoint

<h3>Administrator add access rights for a service clients to the selected endpoint.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddEndpointServiceClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi(config);
            var id = "id_example";  // string | id of the endpoint
            var serviceClients = new ServiceClients(); // ServiceClients |  (optional) 

            try
            {
                // add access rights for given service clients to the selected endpoint
                List<ServiceClient> result = apiInstance.AddEndpointServiceClients(id, serviceClients);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.AddEndpointServiceClients: " + e.Message );
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
 **id** | **string**| id of the endpoint | 
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

<a name="deleteendpoint"></a>
# **DeleteEndpoint**
> void DeleteEndpoint (string id)

delete endpoint

<h3>Administrator removes an endpoint.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteEndpointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi(config);
            var id = 102;  // string | id of the endpoint

            try
            {
                // delete endpoint
                apiInstance.DeleteEndpoint(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.DeleteEndpoint: " + e.Message );
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
 **id** | **string**| id of the endpoint | 

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
| **204** | endpoint deleted |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteendpointserviceclients"></a>
# **DeleteEndpointServiceClients**
> void DeleteEndpointServiceClients (string id, ServiceClients serviceClients = null)

remove access rights from specified service clients to the selected endpoint

<h3>Administrator removes access rights from a service clients to an endpoint.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteEndpointServiceClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi(config);
            var id = "id_example";  // string | id of the endpoint
            var serviceClients = new ServiceClients(); // ServiceClients | Service client to be removed (optional) 

            try
            {
                // remove access rights from specified service clients to the selected endpoint
                apiInstance.DeleteEndpointServiceClients(id, serviceClients);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.DeleteEndpointServiceClients: " + e.Message );
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
 **id** | **string**| id of the endpoint | 
 **serviceClients** | [**ServiceClients**](ServiceClients.md)| Service client to be removed | [optional] 

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
| **204** | access right(s) deleted |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getendpoint"></a>
# **GetEndpoint**
> Endpoint GetEndpoint (string id)

Get an endpoint by its id

<h3>Administrator fetches an endpoint.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetEndpointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi(config);
            var id = 102;  // string | id of the endpoint

            try
            {
                // Get an endpoint by its id
                Endpoint result = apiInstance.GetEndpoint(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetEndpoint: " + e.Message );
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
 **id** | **string**| id of the endpoint | 

### Return type

[**Endpoint**](Endpoint.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | endpoint |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getendpointserviceclients"></a>
# **GetEndpointServiceClients**
> List&lt;ServiceClient&gt; GetEndpointServiceClients (string id)

get service clients who have access rights for the selected endpoint

<h3>Administrator views endpoints access rights.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetEndpointServiceClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi(config);
            var id = "id_example";  // string | id of the endpoint

            try
            {
                // get service clients who have access rights for the selected endpoint
                List<ServiceClient> result = apiInstance.GetEndpointServiceClients(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.GetEndpointServiceClients: " + e.Message );
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
 **id** | **string**| id of the endpoint | 

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
| **200** | list of access rights |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateendpoint"></a>
# **UpdateEndpoint**
> Endpoint UpdateEndpoint (string id, EndpointUpdate endpointUpdate = null)

Update an endpoint

<h3>Administrator updates an endpoint.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UpdateEndpointExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EndpointsApi(config);
            var id = 102;  // string | id of the endpoint
            var endpointUpdate = new EndpointUpdate(); // EndpointUpdate |  (optional) 

            try
            {
                // Update an endpoint
                Endpoint result = apiInstance.UpdateEndpoint(id, endpointUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EndpointsApi.UpdateEndpoint: " + e.Message );
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
 **id** | **string**| id of the endpoint | 
 **endpointUpdate** | [**EndpointUpdate**](EndpointUpdate.md)|  | [optional] 

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
| **200** | endpoint updated |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

