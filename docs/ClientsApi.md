# ChihabHajji.XRoad.Sdk.Api.ClientsApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddClient**](ClientsApi.md#addclient) | **POST** /clients | Add new client for the security server.
[**AddClientLocalGroup**](ClientsApi.md#addclientlocalgroup) | **POST** /clients/{id}/local-groups | add new local group for the security server client
[**AddClientServiceDescription**](ClientsApi.md#addclientservicedescription) | **POST** /clients/{id}/service-descriptions | add new service description for the security server client
[**AddClientTlsCertificate**](ClientsApi.md#addclienttlscertificate) | **POST** /clients/{id}/tls-certificates | add new certificate for the security server client
[**AddServiceClientAccessRights**](ClientsApi.md#addserviceclientaccessrights) | **POST** /clients/{id}/service-clients/{sc_id}/access-rights | Add new access rights for selected service client. If service client did not exist yet, one is created.
[**ChangeOwner**](ClientsApi.md#changeowner) | **PUT** /clients/{id}/make-owner | make client Security Server&#39;s owner. Client must be a member and already registered on the Security Server
[**DeleteClient**](ClientsApi.md#deleteclient) | **DELETE** /clients/{id} | delete security server client
[**DeleteClientTlsCertificate**](ClientsApi.md#deleteclienttlscertificate) | **DELETE** /clients/{id}/tls-certificates/{hash} | delete certificate
[**DeleteOrphans**](ClientsApi.md#deleteorphans) | **DELETE** /clients/{id}/orphans | delete orphaned sign keys, certificates and csrs left behind a delete client
[**DeleteServiceClientAccessRights**](ClientsApi.md#deleteserviceclientaccessrights) | **POST** /clients/{id}/service-clients/{sc_id}/access-rights/delete | remove access rights
[**FindClients**](ClientsApi.md#findclients) | **GET** /clients | find security server clients
[**FindServiceClientCandidates**](ClientsApi.md#findserviceclientcandidates) | **GET** /clients/{id}/service-client-candidates | find ServiceClient candidates for a specific client
[**GetClient**](ClientsApi.md#getclient) | **GET** /clients/{id} | get security server client information
[**GetClientLocalGroups**](ClientsApi.md#getclientlocalgroups) | **GET** /clients/{id}/local-groups | get local groups for the selected client
[**GetClientOrphans**](ClientsApi.md#getclientorphans) | **GET** /clients/{id}/orphans | get information about orphaned sign keys, certificates and csrs left behind a delete client
[**GetClientServiceClients**](ClientsApi.md#getclientserviceclients) | **GET** /clients/{id}/service-clients | get service clients for the selected client&#39;s services
[**GetClientServiceDescriptions**](ClientsApi.md#getclientservicedescriptions) | **GET** /clients/{id}/service-descriptions | get security server client service descriptions
[**GetClientSignCertificates**](ClientsApi.md#getclientsigncertificates) | **GET** /clients/{id}/sign-certificates | get security server client certificates information
[**GetClientTlsCertificate**](ClientsApi.md#getclienttlscertificate) | **GET** /clients/{id}/tls-certificates/{hash} | get TLS certificate
[**GetClientTlsCertificates**](ClientsApi.md#getclienttlscertificates) | **GET** /clients/{id}/tls-certificates | get security server client TLS certificates information
[**GetServiceClient**](ClientsApi.md#getserviceclient) | **GET** /clients/{id}/service-clients/{sc_id} | get single service client by client id and service client id
[**GetServiceClientAccessRights**](ClientsApi.md#getserviceclientaccessrights) | **GET** /clients/{id}/service-clients/{sc_id}/access-rights | get access rights for the selected service client.
[**RegisterClient**](ClientsApi.md#registerclient) | **PUT** /clients/{id}/register | register security server client
[**UnregisterClient**](ClientsApi.md#unregisterclient) | **PUT** /clients/{id}/unregister | unregister security server client
[**UpdateClient**](ClientsApi.md#updateclient) | **PATCH** /clients/{id} | update security server client information


<a name="addclient"></a>
# **AddClient**
> ModelClient AddClient (ClientAdd clientAdd = null)

Add new client for the security server.

<h3>Adds new client to the system.</h3> <p>The client id will be validated and if the validation fails a validation error is returned. Note that with this endpoint it is possible to add an unregistered member as a client. <ul> <li>Attempt to add an unregistered member with <code>ClientAdd.ignore_warnings</code> = false causes the operation to fail with a warning in response's ErrorInfo object.</li> <li>Attempt to add an unregistered member with <code>ClientAdd.ignore_warnings</code> = true succeeds.</li> </ul> </p> <p>When trying to add an unregister client, the error response has an error code <code>unregistered_member</code> and the metadata field contains the identifier of the unregistered client</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var clientAdd = new ClientAdd(); // ClientAdd | client to add (optional) 

            try
            {
                // Add new client for the security server.
                ModelClient result = apiInstance.AddClient(clientAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AddClient: " + e.Message );
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
 **clientAdd** | [**ClientAdd**](ClientAdd.md)| client to add | [optional] 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | new client created |  -  |
| **400** | there are warnings or errors related to the service description |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addclientlocalgroup"></a>
# **AddClientLocalGroup**
> LocalGroup AddClientLocalGroup (string id, LocalGroupAdd localGroupAdd = null)

add new local group for the security server client

<h3>Administrator adds a new local group for the client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddClientLocalGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client
            var localGroupAdd = new LocalGroupAdd(); // LocalGroupAdd | group to add (optional) 

            try
            {
                // add new local group for the security server client
                LocalGroup result = apiInstance.AddClientLocalGroup(id, localGroupAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AddClientLocalGroup: " + e.Message );
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
 **id** | **string**| id of the client | 
 **localGroupAdd** | [**LocalGroupAdd**](LocalGroupAdd.md)| group to add | [optional] 

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
| **201** | local group created |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addclientservicedescription"></a>
# **AddClientServiceDescription**
> ServiceDescription AddClientServiceDescription (string id, ServiceDescriptionAdd serviceDescriptionAdd = null)

add new service description for the security server client

<h3>Administrator adds a new service description for the client.</h3> <p> This endpoint can also return metadata in the error response if adding the service description fails due to invalid URLs, already existing service description or already existing services. If adding the service description fails due to an invalid service URL, the error response will have the error code <code>invalid_service_url</code> and the metadata will contain a list of invalid URLs. If adding the service description fails due to an already existing service description, the error response will have the error code <code>url_already_exists</code> and the metadata will contain the existing URL. If adding the service description fails due to already existing services, the metadata array will have a more complex format. See the description of the '409' response in this endpoint. </p> <p> This endpoint can return a warnings response which can be ignored by setting <code>ServiceDescriptionAdd.ignore_warnings</code> = true. If <code>ServiceDescriptionAdd.ignore_warnings</code> = false, a warnings response will be returned if WSDL or OpenAPI3 validation fails and validation warnings are returned. The warnings will have the warning code <code>wsdl_validation_warnings</code> or <code>openapi_validation_warnings</code> depending on which type the service description is. The metadata of the warning contains the output of the validator itself. </p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddClientServiceDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client
            var serviceDescriptionAdd = new ServiceDescriptionAdd(); // ServiceDescriptionAdd |  (optional) 

            try
            {
                // add new service description for the security server client
                ServiceDescription result = apiInstance.AddClientServiceDescription(id, serviceDescriptionAdd);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AddClientServiceDescription: " + e.Message );
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
 **id** | **string**| id of the client | 
 **serviceDescriptionAdd** | [**ServiceDescriptionAdd**](ServiceDescriptionAdd.md)|  | [optional] 

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
| **201** | service description created |  -  |
| **400** | there are warnings or errors related to the service description |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | &lt;h3&gt;An existing item already exists&lt;/h3&gt; &lt;p&gt; If there are existing WSDL services with the same name, the error response will include the existing services&#39; names and the containing WSDL&#39;s URL in the metadata array. &lt;/p&gt; &lt;p&gt; In this case the error code &lt;code&gt;service_already_exists&lt;/code&gt; (WSDL) or &lt;code&gt;service_code_already_exists&lt;/code&gt; (OPENAPI3) is used and the entries in the metadata array are ordered in following way &lt;ul&gt; &lt;li&gt;metadata has a list of strings [C1,U1,C2,U2....Cn,Un] where&lt;/li&gt; &lt;li&gt;C1 &#x3D; duplicate service full code&lt;/li&gt; &lt;li&gt;U1 &#x3D; URL of the existing WSDL that has the duplicate&lt;/li&gt; &lt;/ul&gt; &lt;/p&gt; &lt;strong&gt;See the example&lt;/strong&gt; |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addclienttlscertificate"></a>
# **AddClientTlsCertificate**
> CertificateDetails AddClientTlsCertificate (string id, System.IO.Stream body = null)

add new certificate for the security server client

<h3>Administrator adds a new certificate for the client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddClientTlsCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | certificate to add (optional) 

            try
            {
                // add new certificate for the security server client
                CertificateDetails result = apiInstance.AddClientTlsCertificate(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AddClientTlsCertificate: " + e.Message );
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
 **id** | **string**| id of the client | 
 **body** | **System.IO.Stream****System.IO.Stream**| certificate to add | [optional] 

### Return type

[**CertificateDetails**](CertificateDetails.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | certificate added |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addserviceclientaccessrights"></a>
# **AddServiceClientAccessRights**
> List&lt;AccessRight&gt; AddServiceClientAccessRights (string id, string scId, AccessRights accessRights = null)

Add new access rights for selected service client. If service client did not exist yet, one is created.

<h3>Adds access rights to the service client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddServiceClientAccessRightsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client who owns the services
            var scId = "scId_example";  // string | id of the service client
            var accessRights = new AccessRights(); // AccessRights |  (optional) 

            try
            {
                // Add new access rights for selected service client. If service client did not exist yet, one is created.
                List<AccessRight> result = apiInstance.AddServiceClientAccessRights(id, scId, accessRights);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.AddServiceClientAccessRights: " + e.Message );
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
 **id** | **string**| id of the client who owns the services | 
 **scId** | **string**| id of the service client | 
 **accessRights** | [**AccessRights**](AccessRights.md)|  | [optional] 

### Return type

[**List&lt;AccessRight&gt;**](AccessRight.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | access right that was added |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeowner"></a>
# **ChangeOwner**
> void ChangeOwner (string id)

make client Security Server's owner. Client must be a member and already registered on the Security Server

<h3>Administrator changes Security Server's owner.</h3> <p>This endpoint can also return metadata in the error response if sending the management request fails. The metadata array contains the error details that were generated in core. The message is in plain English.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class ChangeOwnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = FI:GOV:123;  // string | id of the client to be set as owner

            try
            {
                // make client Security Server's owner. Client must be a member and already registered on the Security Server
                apiInstance.ChangeOwner(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.ChangeOwner: " + e.Message );
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
 **id** | **string**| id of the client to be set as owner | 

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
| **204** | client was set as owner |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclient"></a>
# **DeleteClient**
> void DeleteClient (string id)

delete security server client

<h3>Administrator deletes the client of the security server.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // delete security server client
                apiInstance.DeleteClient(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteClient: " + e.Message );
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
 **id** | **string**| id of the client | 

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
| **204** | client deletion was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclienttlscertificate"></a>
# **DeleteClientTlsCertificate**
> void DeleteClientTlsCertificate (string id, string hash)

delete certificate

<h3>Administrator deletes the certificate from selected client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteClientTlsCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // delete certificate
                apiInstance.DeleteClientTlsCertificate(id, hash);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteClientTlsCertificate: " + e.Message );
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
 **id** | **string**| id of the client | 
 **hash** | **string**| SHA-1 hash of the certificate | 

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
| **204** | certificate deletion was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorphans"></a>
# **DeleteOrphans**
> void DeleteOrphans (string id)

delete orphaned sign keys, certificates and csrs left behind a delete client

<h3>Administrator deletes the orphaned sign keys, certificates and csrs left behind a delete client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteOrphansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // delete orphaned sign keys, certificates and csrs left behind a delete client
                apiInstance.DeleteOrphans(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteOrphans: " + e.Message );
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
 **id** | **string**| id of the client | 

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
| **204** | deletion was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteserviceclientaccessrights"></a>
# **DeleteServiceClientAccessRights**
> void DeleteServiceClientAccessRights (string id, string scId, AccessRights accessRights = null)

remove access rights

<h3>Administrator removes access rights from selected service client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteServiceClientAccessRightsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client who owns the services
            var scId = "scId_example";  // string | id of the service client
            var accessRights = new AccessRights(); // AccessRights | list of access rights to be deleted (optional) 

            try
            {
                // remove access rights
                apiInstance.DeleteServiceClientAccessRights(id, scId, accessRights);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.DeleteServiceClientAccessRights: " + e.Message );
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
 **id** | **string**| id of the client who owns the services | 
 **scId** | **string**| id of the service client | 
 **accessRights** | [**AccessRights**](AccessRights.md)| list of access rights to be deleted | [optional] 

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
| **204** | access right(s) deleted |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findclients"></a>
# **FindClients**
> List&lt;ModelClient&gt; FindClients (string name = null, string instance = null, string memberClass = null, string memberCode = null, string subsystemCode = null, bool? showMembers = null, bool? internalSearch = null, bool? localValidSignCert = null, bool? excludeLocal = null)

find security server clients

<h3>Administrator views the clients of the security server.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class FindClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var name = "name_example";  // string | pass an optional search string (name) for looking up clients (optional) 
            var instance = "instance_example";  // string | pass an optional search string (instance) for looking up clients (optional) 
            var memberClass = "memberClass_example";  // string | pass an optional search string (member_class) for looking up clients (optional) 
            var memberCode = "memberCode_example";  // string | pass an optional search string (member_code) for looking up clients (optional) 
            var subsystemCode = "subsystemCode_example";  // string | pass an optional search string (subsystem_code) for looking up clients (optional) 
            var showMembers = true;  // bool? | to include members for search results (optional)  (default to true)
            var internalSearch = true;  // bool? | to search only clients inside security server (optional)  (default to true)
            var localValidSignCert = true;  // bool? | To search only clients that have (or don't have) a valid (registered, OCSP response GOOD) sign cert stored on this security server. Can be used to search both local and global clients, and can be combined with <code>internal_search</code> and <code>exclude_local</code> parameters. True = limit to clients that have a valid local sign cert, false = limit to clients that don't have a valid local sign cert. (optional) 
            var excludeLocal = false;  // bool? | to search only clients that are not added to this security server (optional)  (default to false)

            try
            {
                // find security server clients
                List<ModelClient> result = apiInstance.FindClients(name, instance, memberClass, memberCode, subsystemCode, showMembers, internalSearch, localValidSignCert, excludeLocal);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.FindClients: " + e.Message );
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
 **name** | **string**| pass an optional search string (name) for looking up clients | [optional] 
 **instance** | **string**| pass an optional search string (instance) for looking up clients | [optional] 
 **memberClass** | **string**| pass an optional search string (member_class) for looking up clients | [optional] 
 **memberCode** | **string**| pass an optional search string (member_code) for looking up clients | [optional] 
 **subsystemCode** | **string**| pass an optional search string (subsystem_code) for looking up clients | [optional] 
 **showMembers** | **bool?**| to include members for search results | [optional] [default to true]
 **internalSearch** | **bool?**| to search only clients inside security server | [optional] [default to true]
 **localValidSignCert** | **bool?**| To search only clients that have (or don&#39;t have) a valid (registered, OCSP response GOOD) sign cert stored on this security server. Can be used to search both local and global clients, and can be combined with &lt;code&gt;internal_search&lt;/code&gt; and &lt;code&gt;exclude_local&lt;/code&gt; parameters. True &#x3D; limit to clients that have a valid local sign cert, false &#x3D; limit to clients that don&#39;t have a valid local sign cert. | [optional] 
 **excludeLocal** | **bool?**| to search only clients that are not added to this security server | [optional] [default to false]

### Return type

[**List&lt;ModelClient&gt;**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of clients |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findserviceclientcandidates"></a>
# **FindServiceClientCandidates**
> List&lt;ServiceClient&gt; FindServiceClientCandidates (string id, string memberNameGroupDescription = null, ServiceClientType? serviceClientType = null, string instance = null, string memberClass = null, string memberGroupCode = null, string subsystemCode = null)

find ServiceClient candidates for a specific client

<h3>Administrator views the clients, globalgroups and localgroups, that could be added as ServiceClients for given Client's services.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class FindServiceClientCandidatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client
            var memberNameGroupDescription = NIIS | Some group description;  // string | pass an optional search string (name) for looking up subjects - name of a member or description of a group (optional) 
            var serviceClientType = (ServiceClientType) "GLOBALGROUP";  // ServiceClientType? | pass an optional search string (service_client_type) for looking up service clients (optional) 
            var instance = GOV;  // string | pass an optional search string (instance) for looking up service clients - full instance id should be used (optional) 
            var memberClass = "memberClass_example";  // string | pass an optional search string (member_class) for looking up service clients (optional) 
            var memberGroupCode = 1234 | Example group code;  // string | pass an optional search string (member_group_code) for looking up service clients - member_code of a member or group_code of a group (optional) 
            var subsystemCode = Subsystem1;  // string | pass an optional search string (subsystem_code) for looking up service clients (optional) 

            try
            {
                // find ServiceClient candidates for a specific client
                List<ServiceClient> result = apiInstance.FindServiceClientCandidates(id, memberNameGroupDescription, serviceClientType, instance, memberClass, memberGroupCode, subsystemCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.FindServiceClientCandidates: " + e.Message );
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
 **id** | **string**| id of the client | 
 **memberNameGroupDescription** | **string**| pass an optional search string (name) for looking up subjects - name of a member or description of a group | [optional] 
 **serviceClientType** | **ServiceClientType?**| pass an optional search string (service_client_type) for looking up service clients | [optional] 
 **instance** | **string**| pass an optional search string (instance) for looking up service clients - full instance id should be used | [optional] 
 **memberClass** | **string**| pass an optional search string (member_class) for looking up service clients | [optional] 
 **memberGroupCode** | **string**| pass an optional search string (member_group_code) for looking up service clients - member_code of a member or group_code of a group | [optional] 
 **subsystemCode** | **string**| pass an optional search string (subsystem_code) for looking up service clients | [optional] 

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

<a name="getclient"></a>
# **GetClient**
> ModelClient GetClient (string id)

get security server client information

<h3>Administrator views the client details of the security server.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // get security server client information
                ModelClient result = apiInstance.GetClient(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClient: " + e.Message );
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
 **id** | **string**| id of the client | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | client object |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientlocalgroups"></a>
# **GetClientLocalGroups**
> List&lt;LocalGroup&gt; GetClientLocalGroups (string id)

get local groups for the selected client

<h3>Administrator views the local groups for the client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetClientLocalGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // get local groups for the selected client
                List<LocalGroup> result = apiInstance.GetClientLocalGroups(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientLocalGroups: " + e.Message );
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
 **id** | **string**| id of the client | 

### Return type

[**List&lt;LocalGroup&gt;**](LocalGroup.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of local groups |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientorphans"></a>
# **GetClientOrphans**
> OrphanInformation GetClientOrphans (string id)

get information about orphaned sign keys, certificates and csrs left behind a delete client

<h3>Administrator has deleted a client and wants to know if some orphaned sign keys, certificates or csrs exist.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetClientOrphansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // get information about orphaned sign keys, certificates and csrs left behind a delete client
                OrphanInformation result = apiInstance.GetClientOrphans(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientOrphans: " + e.Message );
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
 **id** | **string**| id of the client | 

### Return type

[**OrphanInformation**](OrphanInformation.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Information telling that orphans exist. If they don&#39;t exist, 404 is returned instead. |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientserviceclients"></a>
# **GetClientServiceClients**
> List&lt;ServiceClient&gt; GetClientServiceClients (string id)

get service clients for the selected client's services

<h3>Administrator views the service clients for the client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetClientServiceClientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // get service clients for the selected client's services
                List<ServiceClient> result = apiInstance.GetClientServiceClients(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientServiceClients: " + e.Message );
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
 **id** | **string**| id of the client | 

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

<a name="getclientservicedescriptions"></a>
# **GetClientServiceDescriptions**
> List&lt;ServiceDescription&gt; GetClientServiceDescriptions (string id)

get security server client service descriptions

<h3>Administrator views the service descriptions for the client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetClientServiceDescriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // get security server client service descriptions
                List<ServiceDescription> result = apiInstance.GetClientServiceDescriptions(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientServiceDescriptions: " + e.Message );
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
 **id** | **string**| id of the client | 

### Return type

[**List&lt;ServiceDescription&gt;**](ServiceDescription.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of service descriptions |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclientsigncertificates"></a>
# **GetClientSignCertificates**
> List&lt;TokenCertificate&gt; GetClientSignCertificates (string id)

get security server client certificates information

<h3>Administrator views the certificates for the client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetClientSignCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // get security server client certificates information
                List<TokenCertificate> result = apiInstance.GetClientSignCertificates(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientSignCertificates: " + e.Message );
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
 **id** | **string**| id of the client | 

### Return type

[**List&lt;TokenCertificate&gt;**](TokenCertificate.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of certificates |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclienttlscertificate"></a>
# **GetClientTlsCertificate**
> CertificateDetails GetClientTlsCertificate (string id, string hash)

get TLS certificate

<h3>Administrator gets the TLS certificate for the selected client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetClientTlsCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // get TLS certificate
                CertificateDetails result = apiInstance.GetClientTlsCertificate(id, hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientTlsCertificate: " + e.Message );
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
 **id** | **string**| id of the client | 
 **hash** | **string**| SHA-1 hash of the certificate | 

### Return type

[**CertificateDetails**](CertificateDetails.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | certificate details |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclienttlscertificates"></a>
# **GetClientTlsCertificates**
> List&lt;CertificateDetails&gt; GetClientTlsCertificates (string id)

get security server client TLS certificates information

<h3>Administrator views the TLS certificates for the client.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetClientTlsCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // get security server client TLS certificates information
                List<CertificateDetails> result = apiInstance.GetClientTlsCertificates(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClientTlsCertificates: " + e.Message );
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
 **id** | **string**| id of the client | 

### Return type

[**List&lt;CertificateDetails&gt;**](CertificateDetails.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of tls certificates |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceclient"></a>
# **GetServiceClient**
> ServiceClient GetServiceClient (string id, string scId)

get single service client by client id and service client id

<h3>Administrator views the information for a single service client.<h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetServiceClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client
            var scId = "scId_example";  // string | id of the service client

            try
            {
                // get single service client by client id and service client id
                ServiceClient result = apiInstance.GetServiceClient(id, scId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetServiceClient: " + e.Message );
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
 **id** | **string**| id of the client | 
 **scId** | **string**| id of the service client | 

### Return type

[**ServiceClient**](ServiceClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | single service clients |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getserviceclientaccessrights"></a>
# **GetServiceClientAccessRights**
> List&lt;AccessRight&gt; GetServiceClientAccessRights (string id, string scId)

get access rights for the selected service client.

<h3>Administrator views service client's access rights.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetServiceClientAccessRightsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client who owns the services
            var scId = "scId_example";  // string | id of the service client

            try
            {
                // get access rights for the selected service client.
                List<AccessRight> result = apiInstance.GetServiceClientAccessRights(id, scId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.GetServiceClientAccessRights: " + e.Message );
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
 **id** | **string**| id of the client who owns the services | 
 **scId** | **string**| id of the service client | 

### Return type

[**List&lt;AccessRight&gt;**](AccessRight.md)

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

<a name="registerclient"></a>
# **RegisterClient**
> void RegisterClient (string id)

register security server client

<h3>Administrator registers client.</h3> <p>This endpoint can also return metadata in the error response if sending the management request fails. The metadata array contains the error details that were generated in core. The message is in plain English.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class RegisterClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // register security server client
                apiInstance.RegisterClient(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.RegisterClient: " + e.Message );
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
 **id** | **string**| id of the client | 

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
| **204** | client was registered |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregisterclient"></a>
# **UnregisterClient**
> void UnregisterClient (string id)

unregister security server client

<h3>Administrator unregisters client.</h3> <p>This endpoint can also return metadata in the error response if sending the management request fails. The metadata array contains the error details that were generated in core. The message is in plain English.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UnregisterClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client

            try
            {
                // unregister security server client
                apiInstance.UnregisterClient(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.UnregisterClient: " + e.Message );
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
 **id** | **string**| id of the client | 

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
| **204** | unregister was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclient"></a>
# **UpdateClient**
> ModelClient UpdateClient (string id, ConnectionTypeWrapper connectionTypeWrapper = null)

update security server client information

<h3>Administrator updates the client information.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UpdateClientExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(config);
            var id = "id_example";  // string | id of the client
            var connectionTypeWrapper = new ConnectionTypeWrapper(); // ConnectionTypeWrapper |  (optional) 

            try
            {
                // update security server client information
                ModelClient result = apiInstance.UpdateClient(id, connectionTypeWrapper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.UpdateClient: " + e.Message );
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
 **id** | **string**| id of the client | 
 **connectionTypeWrapper** | [**ConnectionTypeWrapper**](ConnectionTypeWrapper.md)|  | [optional] 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | client modified |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

