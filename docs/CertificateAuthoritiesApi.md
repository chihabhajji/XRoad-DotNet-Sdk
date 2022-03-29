# ChihabHajji.XRoad.Sdk.Api.CertificateAuthoritiesApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApprovedCertificateAuthorities**](CertificateAuthoritiesApi.md#getapprovedcertificateauthorities) | **GET** /certificate-authorities | view the approved certificate authorities
[**GetSubjectFieldDescriptions**](CertificateAuthoritiesApi.md#getsubjectfielddescriptions) | **GET** /certificate-authorities/{ca_name}/csr-subject-fields | get description of subject DN fields for CSR


<a name="getapprovedcertificateauthorities"></a>
# **GetApprovedCertificateAuthorities**
> List&lt;CertificateAuthority&gt; GetApprovedCertificateAuthorities (KeyUsageType? keyUsageType = null, bool? includeIntermediateCas = null)

view the approved certificate authorities

<h3>Administrator views the approved certificate authorities.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetApprovedCertificateAuthoritiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CertificateAuthoritiesApi(config);
            var keyUsageType = (KeyUsageType) "AUTHENTICATION";  // KeyUsageType? | return only CAs suitable for this type of key usage (optional) 
            var includeIntermediateCas = false;  // bool? | if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \"false\". (optional)  (default to false)

            try
            {
                // view the approved certificate authorities
                List<CertificateAuthority> result = apiInstance.GetApprovedCertificateAuthorities(keyUsageType, includeIntermediateCas);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificateAuthoritiesApi.GetApprovedCertificateAuthorities: " + e.Message );
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
 **keyUsageType** | **KeyUsageType?**| return only CAs suitable for this type of key usage | [optional] 
 **includeIntermediateCas** | **bool?**| if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \&quot;false\&quot;. | [optional] [default to false]

### Return type

[**List&lt;CertificateAuthority&gt;**](CertificateAuthority.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of approved certificate authorities |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubjectfielddescriptions"></a>
# **GetSubjectFieldDescriptions**
> List&lt;CsrSubjectFieldDescription&gt; GetSubjectFieldDescriptions (string caName, KeyUsageType keyUsageType, string keyId = null, string memberId = null, bool? isNewMember = null)

get description of subject DN fields for CSR

<h3>List DN field descriptions to collect CSR parameters</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetSubjectFieldDescriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CertificateAuthoritiesApi(config);
            var caName = X-Road Test CA CN;  // string | common name of the CA
            var keyUsageType = (KeyUsageType) "AUTHENTICATION";  // KeyUsageType | which usage type this CSR is for
            var keyId = "keyId_example";  // string | id of the key. If provided, used only for validating correct key usage (optional) 
            var memberId = FI:GOV:123;  // string | member client id for signing CSRs. <instance_id>:<member_class>:<member_code> (optional) 
            var isNewMember = false;  // bool? | whether or not the member in the member_id parameter is a new member (optional)  (default to false)

            try
            {
                // get description of subject DN fields for CSR
                List<CsrSubjectFieldDescription> result = apiInstance.GetSubjectFieldDescriptions(caName, keyUsageType, keyId, memberId, isNewMember);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificateAuthoritiesApi.GetSubjectFieldDescriptions: " + e.Message );
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
 **caName** | **string**| common name of the CA | 
 **keyUsageType** | **KeyUsageType**| which usage type this CSR is for | 
 **keyId** | **string**| id of the key. If provided, used only for validating correct key usage | [optional] 
 **memberId** | **string**| member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; | [optional] 
 **isNewMember** | **bool?**| whether or not the member in the member_id parameter is a new member | [optional] [default to false]

### Return type

[**List&lt;CsrSubjectFieldDescription&gt;**](CsrSubjectFieldDescription.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | csr subject field objects |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

