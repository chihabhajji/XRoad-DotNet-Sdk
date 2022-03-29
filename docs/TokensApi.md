# ChihabHajji.XRoad.Sdk.Api.TokensApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddKey**](TokensApi.md#addkey) | **POST** /tokens/{id}/keys | add new key
[**AddKeyAndCsr**](TokensApi.md#addkeyandcsr) | **POST** /tokens/{id}/keys-with-csrs | add a new key and generate a csr for it
[**GetToken**](TokensApi.md#gettoken) | **GET** /tokens/{id} | get security server token information
[**GetTokens**](TokensApi.md#gettokens) | **GET** /tokens | get security server tokens
[**LoginToken**](TokensApi.md#logintoken) | **PUT** /tokens/{id}/login | login to token
[**LogoutToken**](TokensApi.md#logouttoken) | **PUT** /tokens/{id}/logout | logout from token
[**UpdateToken**](TokensApi.md#updatetoken) | **PATCH** /tokens/{id} | update security server token information
[**UpdateTokenPin**](TokensApi.md#updatetokenpin) | **PUT** /tokens/{id}/pin | update security server software token pin code


<a name="addkey"></a>
# **AddKey**
> Key AddKey (string id, KeyLabel keyLabel = null)

add new key

<h3>Adds key for selected token.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokensApi(config);
            var id = "id_example";  // string | id of the token
            var keyLabel = new KeyLabel(); // KeyLabel |  (optional) 

            try
            {
                // add new key
                Key result = apiInstance.AddKey(id, keyLabel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.AddKey: " + e.Message );
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
 **id** | **string**| id of the token | 
 **keyLabel** | [**KeyLabel**](KeyLabel.md)|  | [optional] 

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
| **201** | key created for the token |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists or token not logged in |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addkeyandcsr"></a>
# **AddKeyAndCsr**
> KeyWithCertificateSigningRequestId AddKeyAndCsr (string id, KeyLabelWithCsrGenerate keyLabelWithCsrGenerate = null)

add a new key and generate a csr for it

<h3>Administrator adds a new key and generates a csr for it.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddKeyAndCsrExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokensApi(config);
            var id = "id_example";  // string | id of the token
            var keyLabelWithCsrGenerate = new KeyLabelWithCsrGenerate(); // KeyLabelWithCsrGenerate |  (optional) 

            try
            {
                // add a new key and generate a csr for it
                KeyWithCertificateSigningRequestId result = apiInstance.AddKeyAndCsr(id, keyLabelWithCsrGenerate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.AddKeyAndCsr: " + e.Message );
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
 **id** | **string**| id of the token | 
 **keyLabelWithCsrGenerate** | [**KeyLabelWithCsrGenerate**](KeyLabelWithCsrGenerate.md)|  | [optional] 

### Return type

[**KeyWithCertificateSigningRequestId**](KeyWithCertificateSigningRequestId.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | key created for the token |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists or token not logged in |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettoken"></a>
# **GetToken**
> Token GetToken (string id)

get security server token information

<h3>Administrator views the token details of the security server.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokensApi(config);
            var id = "id_example";  // string | id of the token

            try
            {
                // get security server token information
                Token result = apiInstance.GetToken(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.GetToken: " + e.Message );
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
 **id** | **string**| id of the token | 

### Return type

[**Token**](Token.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | token object |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokens"></a>
# **GetTokens**
> List&lt;Token&gt; GetTokens ()

get security server tokens

<h3>Administrator views tokens of the security server.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokensApi(config);

            try
            {
                // get security server tokens
                List<Token> result = apiInstance.GetTokens();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.GetTokens: " + e.Message );
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

[**List&lt;Token&gt;**](Token.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of tokens |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logintoken"></a>
# **LoginToken**
> Token LoginToken (string id, TokenPassword tokenPassword = null)

login to token

<h3>Administrator logs in to a token</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class LoginTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokensApi(config);
            var id = "id_example";  // string | id of the token
            var tokenPassword = new TokenPassword(); // TokenPassword |  (optional) 

            try
            {
                // login to token
                Token result = apiInstance.LoginToken(id, tokenPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.LoginToken: " + e.Message );
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
 **id** | **string**| id of the token | 
 **tokenPassword** | [**TokenPassword**](TokenPassword.md)|  | [optional] 

### Return type

[**Token**](Token.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | logged in |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logouttoken"></a>
# **LogoutToken**
> Token LogoutToken (string id)

logout from token

<h3>Administrator logs out from token.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class LogoutTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokensApi(config);
            var id = "id_example";  // string | id of the token

            try
            {
                // logout from token
                Token result = apiInstance.LogoutToken(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.LogoutToken: " + e.Message );
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
 **id** | **string**| id of the token | 

### Return type

[**Token**](Token.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | logged out |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetoken"></a>
# **UpdateToken**
> Token UpdateToken (string id, TokenName tokenName = null)

update security server token information

<h3>Administrator updates the token information.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UpdateTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokensApi(config);
            var id = "id_example";  // string | id of the token
            var tokenName = new TokenName(); // TokenName |  (optional) 

            try
            {
                // update security server token information
                Token result = apiInstance.UpdateToken(id, tokenName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.UpdateToken: " + e.Message );
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
 **id** | **string**| id of the token | 
 **tokenName** | [**TokenName**](TokenName.md)|  | [optional] 

### Return type

[**Token**](Token.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | token modified |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetokenpin"></a>
# **UpdateTokenPin**
> void UpdateTokenPin (string id, TokenPinUpdate tokenPinUpdate = null)

update security server software token pin code

<h3>Administrator updates the software token pin code.</h3> <p>This operation supports updating the pin code of a software token only.</p> <p> This endpoint can also return metadata in the error response. The metadata array can contain error messages about why the init did not succeed. If the pin code is too weak, the error code <code>weak_pin</code> is used and the entries in the metadata array are always ordered in following way <ul> <li>metadata has a list of strings [\"pin_min_length\", x, \"pin_min_char_classes_count\", y] where</li> <li>x = the minimum length of the pin code</li> <li>y = the minimum amount of character classes (e.g. uppercase, number, special characters) to be used in the pin code</li> </ul> </p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UpdateTokenPinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TokensApi(config);
            var id = "id_example";  // string | id of the software token
            var tokenPinUpdate = new TokenPinUpdate(); // TokenPinUpdate |  (optional) 

            try
            {
                // update security server software token pin code
                apiInstance.UpdateTokenPin(id, tokenPinUpdate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.UpdateTokenPin: " + e.Message );
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
 **id** | **string**| id of the software token | 
 **tokenPinUpdate** | [**TokenPinUpdate**](TokenPinUpdate.md)|  | [optional] 

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
| **204** | software token pin updated |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

