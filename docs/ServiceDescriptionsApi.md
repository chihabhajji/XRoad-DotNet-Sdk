# ChihabHajji.XRoad.Sdk.Api.ServiceDescriptionsApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteServiceDescription**](ServiceDescriptionsApi.md#deleteservicedescription) | **DELETE** /service-descriptions/{id} | delete service description
[**DisableServiceDescription**](ServiceDescriptionsApi.md#disableservicedescription) | **PUT** /service-descriptions/{id}/disable | disable selected service description
[**EnableServiceDescription**](ServiceDescriptionsApi.md#enableservicedescription) | **PUT** /service-descriptions/{id}/enable | enable selected service description
[**GetServiceDescription**](ServiceDescriptionsApi.md#getservicedescription) | **GET** /service-descriptions/{id} | get service description with provided id
[**GetServiceDescriptionServices**](ServiceDescriptionsApi.md#getservicedescriptionservices) | **GET** /service-descriptions/{id}/services | get services for the selected service description
[**RefreshServiceDescription**](ServiceDescriptionsApi.md#refreshservicedescription) | **PUT** /service-descriptions/{id}/refresh | refresh selected service description
[**UpdateServiceDescription**](ServiceDescriptionsApi.md#updateservicedescription) | **PATCH** /service-descriptions/{id} | update url or service code for the selected service description


<a name="deleteservicedescription"></a>
# **DeleteServiceDescription**
> void DeleteServiceDescription (string id)

delete service description

<h3>Administrator deletes the service description.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteServiceDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDescriptionsApi(config);
            var id = "id_example";  // string | id of the service description

            try
            {
                // delete service description
                apiInstance.DeleteServiceDescription(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceDescriptionsApi.DeleteServiceDescription: " + e.Message );
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
 **id** | **string**| id of the service description | 

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
| **204** | service description deletion was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disableservicedescription"></a>
# **DisableServiceDescription**
> void DisableServiceDescription (string id, ServiceDescriptionDisabledNotice serviceDescriptionDisabledNotice = null)

disable selected service description

<h3>Administrator disables service description.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DisableServiceDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDescriptionsApi(config);
            var id = "id_example";  // string | id of the service description
            var serviceDescriptionDisabledNotice = new ServiceDescriptionDisabledNotice(); // ServiceDescriptionDisabledNotice |  (optional) 

            try
            {
                // disable selected service description
                apiInstance.DisableServiceDescription(id, serviceDescriptionDisabledNotice);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceDescriptionsApi.DisableServiceDescription: " + e.Message );
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
 **id** | **string**| id of the service description | 
 **serviceDescriptionDisabledNotice** | [**ServiceDescriptionDisabledNotice**](ServiceDescriptionDisabledNotice.md)|  | [optional] 

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
| **204** | service description disabled |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enableservicedescription"></a>
# **EnableServiceDescription**
> void EnableServiceDescription (string id)

enable selected service description

<h3>Administrator enables service description.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class EnableServiceDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDescriptionsApi(config);
            var id = "id_example";  // string | id of the service description

            try
            {
                // enable selected service description
                apiInstance.EnableServiceDescription(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceDescriptionsApi.EnableServiceDescription: " + e.Message );
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
 **id** | **string**| id of the service description | 

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
| **204** | service description enabled |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservicedescription"></a>
# **GetServiceDescription**
> ServiceDescription GetServiceDescription (string id)

get service description with provided id

<h3>Administrator views a service description with a certain id.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetServiceDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDescriptionsApi(config);
            var id = "id_example";  // string | id of the service description

            try
            {
                // get service description with provided id
                ServiceDescription result = apiInstance.GetServiceDescription(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceDescriptionsApi.GetServiceDescription: " + e.Message );
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
 **id** | **string**| id of the service description | 

### Return type

[**ServiceDescription**](ServiceDescription.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | wanted service description |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservicedescriptionservices"></a>
# **GetServiceDescriptionServices**
> List&lt;Service&gt; GetServiceDescriptionServices (string id)

get services for the selected service description

<h3>Administrator views the services for the selected service description.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetServiceDescriptionServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDescriptionsApi(config);
            var id = "id_example";  // string | id of the service description

            try
            {
                // get services for the selected service description
                List<Service> result = apiInstance.GetServiceDescriptionServices(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceDescriptionsApi.GetServiceDescriptionServices: " + e.Message );
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
 **id** | **string**| id of the service description | 

### Return type

[**List&lt;Service&gt;**](Service.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of services |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshservicedescription"></a>
# **RefreshServiceDescription**
> ServiceDescription RefreshServiceDescription (string id, IgnoreWarnings ignoreWarnings = null)

refresh selected service description

<h3>Administrator refreshes service description.</h3> <p> This endpoint can also return metadata in the error response if refreshing the service description fails due to invalid URLs, already existing service description or already existing services. If refreshing the service description fails due to an invalid service URL, the error response will have the error code <code>invalid_service_url</code> and the metadata will contain a list of invalid URLs. If refreshing the service description fails due to an already existing service description, the error response will have the error code <code>url_already_exists</code> and the metadata will contain the existing URL. If refreshing the service description fails due to already existing services, the metadata array will have a more complex format. See the description of the '409' response in this endpoint. </p> <p> This endpoint can return a warnings response which can be ignored by setting <code>IgnoreWarnings.ignore_warnings</code> = true. If <code>IgnoreWarnings.ignore_warnings</code> = false, a warnings response will be returned if any one of the following conditions is true <ul> <li>WSDL or OpenAPI3 validation fails and validation warnings are returned (warning code will be either <code>wsdl_validation_warnings</code> or <code>openapi_validation_warnings</code>)</li> <li>existing services will be removed (warning code <code>deleting_services</code> and the warning metadata contains a list of service codes that will be removed)</li> <li>new services will be added (warning code <code>adding_services</code> and the warning metadata contains a list of service codes that will be added)</li> </ul> </p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class RefreshServiceDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDescriptionsApi(config);
            var id = "id_example";  // string | id of the service description
            var ignoreWarnings = new IgnoreWarnings(); // IgnoreWarnings |  (optional) 

            try
            {
                // refresh selected service description
                ServiceDescription result = apiInstance.RefreshServiceDescription(id, ignoreWarnings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceDescriptionsApi.RefreshServiceDescription: " + e.Message );
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
 **id** | **string**| id of the service description | 
 **ignoreWarnings** | [**IgnoreWarnings**](IgnoreWarnings.md)|  | [optional] 

### Return type

[**ServiceDescription**](ServiceDescription.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | service description refreshed |  -  |
| **400** | there are warnings or errors related to the service description |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | &lt;h3&gt;An existing item already exists&lt;/h3&gt; &lt;p&gt; If there are existing WSDL services with the same name, the error response will include the existing services&#39; names and the containing WSDL&#39;s URL in the metadata array. &lt;/p&gt; &lt;p&gt; In this case the error code &lt;code&gt;service_already_exists&lt;/code&gt; (WSDL) or &lt;code&gt;service_code_already_exists&lt;/code&gt; (OPENAPI3) is used and the entries in the metadata array are ordered in following way &lt;ul&gt; &lt;li&gt;metadata has a list of strings [C1,U1,C2,U2....Cn,Un] where&lt;/li&gt; &lt;li&gt;C1 &#x3D; duplicate service full code&lt;/li&gt; &lt;li&gt;U1 &#x3D; URL of the existing WSDL that has the duplicate&lt;/li&gt; &lt;/ul&gt; &lt;/p&gt; &lt;strong&gt;See the example&lt;/strong&gt; |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateservicedescription"></a>
# **UpdateServiceDescription**
> ServiceDescription UpdateServiceDescription (string id, ServiceDescriptionUpdate serviceDescriptionUpdate = null)

update url or service code for the selected service description

<h3>Administrator updates the selected service description.</h3> <p> This endpoint can also return metadata in the error response if updating the service description fails due to invalid URLs, already existing service description or already existing services. If updating the service description fails due to an invalid service URL, the error response will have the error code <code>invalid_service_url</code> and the metadata will contain a list of invalid URLs. If updating the service description fails due to an already existing service description, the error response will have the error code <code>url_already_exists</code> and the metadata will contain the existing URL. If updating the service description fails due to already existing services, the metadata array will have a more complex format. See the description of the '409' response in this endpoint. </p> <p> This endpoint can return a warnings response which can be ignored by setting <code>ServiceDescriptionUpdate.ignore_warnings</code> = true. If <code>ServiceDescriptionUpdate.ignore_warnings</code> = false, a warnings response will be returned if any one of the following conditions is true <ul> <li>WSDL or OpenAPI3 validation fails and validation warnings are returned (warning code will be either <code>wsdl_validation_warnings</code> or <code>openapi_validation_warnings</code>)</li> <li>existing services will be removed (warning code <code>deleting_services</code> and the warning metadata contains a list of service codes that will be removed)</li> <li>new services will be added (warning code <code>adding_services</code> and the warning metadata contains a list of service codes that will be added)</li> </ul> </p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UpdateServiceDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ServiceDescriptionsApi(config);
            var id = "id_example";  // string | id of the service description
            var serviceDescriptionUpdate = new ServiceDescriptionUpdate(); // ServiceDescriptionUpdate |  (optional) 

            try
            {
                // update url or service code for the selected service description
                ServiceDescription result = apiInstance.UpdateServiceDescription(id, serviceDescriptionUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceDescriptionsApi.UpdateServiceDescription: " + e.Message );
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
 **id** | **string**| id of the service description | 
 **serviceDescriptionUpdate** | [**ServiceDescriptionUpdate**](ServiceDescriptionUpdate.md)|  | [optional] 

### Return type

[**ServiceDescription**](ServiceDescription.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | service description modified |  -  |
| **400** | there are warnings or errors related to the service description |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | &lt;h3&gt;An existing item already exists&lt;/h3&gt; &lt;p&gt; If there are existing WSDL services with the same name, the error response will include the existing services&#39; names and the containing WSDL&#39;s URL in the metadata array. &lt;/p&gt; &lt;p&gt; In this case the error code &lt;code&gt;service_already_exists&lt;/code&gt; (WSDL) or &lt;code&gt;service_code_already_exists&lt;/code&gt; (OPENAPI3) is used and the entries in the metadata array are ordered in following way &lt;ul&gt; &lt;li&gt;metadata has a list of strings [C1,U1,C2,U2....Cn,Un] where&lt;/li&gt; &lt;li&gt;C1 &#x3D; duplicate service full code&lt;/li&gt; &lt;li&gt;U1 &#x3D; URL of the existing WSDL that has the duplicate&lt;/li&gt; &lt;/ul&gt; &lt;/p&gt; &lt;strong&gt;See the example&lt;/strong&gt; |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

