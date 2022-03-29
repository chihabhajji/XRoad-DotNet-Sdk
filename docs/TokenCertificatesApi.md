# ChihabHajji.XRoad.Sdk.Api.TokenCertificatesApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateCertificate**](TokenCertificatesApi.md#activatecertificate) | **PUT** /token-certificates/{hash}/activate | activate certificate
[**DeleteCertificate**](TokenCertificatesApi.md#deletecertificate) | **DELETE** /token-certificates/{hash} | delete certificate
[**DisableCertificate**](TokenCertificatesApi.md#disablecertificate) | **PUT** /token-certificates/{hash}/disable | deactivate certificate
[**GetCertificate**](TokenCertificatesApi.md#getcertificate) | **GET** /token-certificates/{hash} | get certificate information
[**GetPossibleActionsForCertificate**](TokenCertificatesApi.md#getpossibleactionsforcertificate) | **GET** /token-certificates/{hash}/possible-actions | get possible actions for one certificate
[**ImportCertificate**](TokenCertificatesApi.md#importcertificate) | **POST** /token-certificates | import new certificate
[**ImportCertificateFromToken**](TokenCertificatesApi.md#importcertificatefromtoken) | **POST** /token-certificates/{hash}/import | import an existing certificate from a token by cert hash
[**MarkAuthCertForDeletion**](TokenCertificatesApi.md#markauthcertfordeletion) | **PUT** /token-certificates/{hash}/mark-for-deletion | marks an auth certificate for deletion
[**RegisterCertificate**](TokenCertificatesApi.md#registercertificate) | **PUT** /token-certificates/{hash}/register | register certificate
[**UnregisterAuthCertificate**](TokenCertificatesApi.md#unregisterauthcertificate) | **PUT** /token-certificates/{hash}/unregister | unregister authentication certificate


<a name="activatecertificate"></a>
# **ActivateCertificate**
> void ActivateCertificate (string hash)

activate certificate

<h3>Administrator activates selected certificate.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class ActivateCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // activate certificate
                apiInstance.ActivateCertificate(hash);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.ActivateCertificate: " + e.Message );
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
| **204** | request was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecertificate"></a>
# **DeleteCertificate**
> void DeleteCertificate (string hash)

delete certificate

<h3>Administrator deletes the certificate.</h3> <p>This endpoint can also return metadata in the error response if the certificate is not found. The metadata array contains the id of that certificate.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // delete certificate
                apiInstance.DeleteCertificate(hash);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.DeleteCertificate: " + e.Message );
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
 **hash** | **string**| SHA-1 hash of the certificate | 

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

<a name="disablecertificate"></a>
# **DisableCertificate**
> void DisableCertificate (string hash)

deactivate certificate

<h3>Administrator deactivates selected certificate.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DisableCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // deactivate certificate
                apiInstance.DisableCertificate(hash);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.DisableCertificate: " + e.Message );
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
| **204** | certificate was deactivated |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcertificate"></a>
# **GetCertificate**
> TokenCertificate GetCertificate (string hash)

get certificate information

<h3>Administrator views certificate details.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // get certificate information
                TokenCertificate result = apiInstance.GetCertificate(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.GetCertificate: " + e.Message );
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
 **hash** | **string**| SHA-1 hash of the certificate | 

### Return type

[**TokenCertificate**](TokenCertificate.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | token certificate |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpossibleactionsforcertificate"></a>
# **GetPossibleActionsForCertificate**
> List&lt;PossibleAction&gt; GetPossibleActionsForCertificate (string hash)

get possible actions for one certificate

<h3>UI needs to know which actions can be done on one certificate.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetPossibleActionsForCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // get possible actions for one certificate
                List<PossibleAction> result = apiInstance.GetPossibleActionsForCertificate(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.GetPossibleActionsForCertificate: " + e.Message );
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
 **hash** | **string**| SHA-1 hash of the certificate | 

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

<a name="importcertificate"></a>
# **ImportCertificate**
> TokenCertificate ImportCertificate (System.IO.Stream body = null)

import new certificate

<h3>Imports certificate to the system.</h3> <p>This endpoint can also return metadata in the error response if the client for the certificate is not found. The metadata array contains the identifier of that client.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class ImportCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | certificate to import (optional) 

            try
            {
                // import new certificate
                TokenCertificate result = apiInstance.ImportCertificate(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.ImportCertificate: " + e.Message );
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
 **body** | **System.IO.Stream****System.IO.Stream**| certificate to import | [optional] 

### Return type

[**TokenCertificate**](TokenCertificate.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | certificate created |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importcertificatefromtoken"></a>
# **ImportCertificateFromToken**
> TokenCertificate ImportCertificateFromToken (string hash)

import an existing certificate from a token by cert hash

<h3>Imports certificate from a token to the system.</h3> <p>This endpoint can also return metadata in the error response if the client for this certificate is not found. The metadata contains the identifier of that client.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class ImportCertificateFromTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // import an existing certificate from a token by cert hash
                TokenCertificate result = apiInstance.ImportCertificateFromToken(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.ImportCertificateFromToken: " + e.Message );
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
 **hash** | **string**| SHA-1 hash of the certificate | 

### Return type

[**TokenCertificate**](TokenCertificate.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | the imported certificate |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markauthcertfordeletion"></a>
# **MarkAuthCertForDeletion**
> void MarkAuthCertForDeletion (string hash)

marks an auth certificate for deletion

<h3>Administrator marks an auth certificate for deletion.</h3> <p>This endpoint can also return metadata in the error response if sending the management request fails. The metadata array contains the error details that were generated in core. The message is in plain English.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class MarkAuthCertForDeletionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // marks an auth certificate for deletion
                apiInstance.MarkAuthCertForDeletion(hash);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.MarkAuthCertForDeletion: " + e.Message );
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
 **hash** | **string**| SHA-1 hash of the certificate | 

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
| **204** | request was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registercertificate"></a>
# **RegisterCertificate**
> void RegisterCertificate (string hash, SecurityServerAddress securityServerAddress = null)

register certificate

<h3>Administrator registers selected certificate.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class RegisterCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var hash = "hash_example";  // string | SHA-1 hash of the certificate
            var securityServerAddress = new SecurityServerAddress(); // SecurityServerAddress |  (optional) 

            try
            {
                // register certificate
                apiInstance.RegisterCertificate(hash, securityServerAddress);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.RegisterCertificate: " + e.Message );
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
 **hash** | **string**| SHA-1 hash of the certificate | 
 **securityServerAddress** | [**SecurityServerAddress**](SecurityServerAddress.md)|  | [optional] 

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
| **200** | request was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregisterauthcertificate"></a>
# **UnregisterAuthCertificate**
> void UnregisterAuthCertificate (string hash)

unregister authentication certificate

<h3>Administrator unregisters selected authentication certificate.</h3> <p>This endpoint can also return metadata in the error response if sending the management request fails. The metadata array contains the error details that were generated in core. The message is in plain English.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UnregisterAuthCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokenCertificatesApi(config);
            var hash = "hash_example";  // string | SHA-1 hash of the certificate

            try
            {
                // unregister authentication certificate
                apiInstance.UnregisterAuthCertificate(hash);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenCertificatesApi.UnregisterAuthCertificate: " + e.Message );
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
 **hash** | **string**| SHA-1 hash of the certificate | 

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
| **204** | request was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

