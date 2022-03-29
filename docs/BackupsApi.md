# ChihabHajji.XRoad.Sdk.Api.BackupsApi

All URIs are relative to */api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBackup**](BackupsApi.md#addbackup) | **POST** /backups | add new backup for the security server
[**AddBackupExt**](BackupsApi.md#addbackupext) | **POST** /backups/ext | add new backup for the security server and return extra backup state
[**DeleteBackup**](BackupsApi.md#deletebackup) | **DELETE** /backups/{filename} | delete security server backup
[**DownloadBackup**](BackupsApi.md#downloadbackup) | **GET** /backups/{filename}/download | download security server backup
[**GetBackups**](BackupsApi.md#getbackups) | **GET** /backups | get security server backups
[**RestoreBackup**](BackupsApi.md#restorebackup) | **PUT** /backups/{filename}/restore | restore security server configuration from backup
[**UploadBackup**](BackupsApi.md#uploadbackup) | **POST** /backups/upload | upload new backup for the security server


<a name="addbackup"></a>
# **AddBackup**
> Backup AddBackup ()

add new backup for the security server

<h3>Adds security server backup to the system.</h3> <p>This endpoint can also return metadata in the error response. The metadata array contains the output of a failed backup generation script.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BackupsApi(config);

            try
            {
                // add new backup for the security server
                Backup result = apiInstance.AddBackup();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.AddBackup: " + e.Message );
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

[**Backup**](Backup.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | item created |  -  |
| **202** | item accepted |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addbackupext"></a>
# **AddBackupExt**
> BackupExt AddBackupExt ()

add new backup for the security server and return extra backup state

<h3>Adds security server backup to the system.</h3> <p>This endpoint can also return metadata in the error response. The metadata array contains the output of a failed backup generation script.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class AddBackupExtExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BackupsApi(config);

            try
            {
                // add new backup for the security server and return extra backup state
                BackupExt result = apiInstance.AddBackupExt();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.AddBackupExt: " + e.Message );
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

[**BackupExt**](BackupExt.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | item created |  -  |
| **202** | item accepted |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebackup"></a>
# **DeleteBackup**
> void DeleteBackup (string filename)

delete security server backup

<h3>Administrator deletes the backup of the security server.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DeleteBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BackupsApi(config);
            var filename = "filename_example";  // string | filename of the backup

            try
            {
                // delete security server backup
                apiInstance.DeleteBackup(filename);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.DeleteBackup: " + e.Message );
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
 **filename** | **string**| filename of the backup | 

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
| **204** | deletion was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadbackup"></a>
# **DownloadBackup**
> System.IO.Stream DownloadBackup (string filename)

download security server backup

<h3>Administrator downloads the backup of the security server.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class DownloadBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BackupsApi(config);
            var filename = "filename_example";  // string | filename of the backup

            try
            {
                // download security server backup
                System.IO.Stream result = apiInstance.DownloadBackup(filename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.DownloadBackup: " + e.Message );
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
 **filename** | **string**| filename of the backup | 

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
| **200** | backup file downloaded |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbackups"></a>
# **GetBackups**
> List&lt;Backup&gt; GetBackups ()

get security server backups

<h3>Administrator views the backups for the security server.</h3>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class GetBackupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BackupsApi(config);

            try
            {
                // get security server backups
                List<Backup> result = apiInstance.GetBackups();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.GetBackups: " + e.Message );
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

[**List&lt;Backup&gt;**](Backup.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | list of security server backups |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restorebackup"></a>
# **RestoreBackup**
> TokensLoggedOut RestoreBackup (string filename)

restore security server configuration from backup

<h3>Administrator restores the security server configuration from backup.</h3> <p>This endpoint can also return metadata in the error response. The metadata array contains the output of a failed backup restore script.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class RestoreBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BackupsApi(config);
            var filename = "filename_example";  // string | filename of the backup

            try
            {
                // restore security server configuration from backup
                TokensLoggedOut result = apiInstance.RestoreBackup(filename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.RestoreBackup: " + e.Message );
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
 **filename** | **string**| filename of the backup | 

### Return type

[**TokensLoggedOut**](TokensLoggedOut.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | restore was successful |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadbackup"></a>
# **UploadBackup**
> Backup UploadBackup (bool? ignoreWarnings = null, System.IO.Stream file = null)

upload new backup for the security server

<h3>Uploads new security server backup to the system.</h3> <p>Note that it is possible to overwrite an existing backup file with the same name. <ul> <li>Attempt to upload a new backup file having the same name with an existing backup and with query parameter <code>ignore_warnings</code> = false causes the operation to fail with a warning in response's ErrorInfo object.</li> <li>Attempt to upload a new backup file having the same name with an existing backup and with query parameter <code>ignore_warnings</code> = true will overwrite the existing backup.</li> </ul> </p> <p>The warning response has a warning code <code>warning_file_already_exists</code> and the metadata field contains the name of the existing backup</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChihabHajji.XRoad.Sdk.Api;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace Example
{
    public class UploadBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BackupsApi(config);
            var ignoreWarnings = false;  // bool? | If true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail. (optional)  (default to false)
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // upload new backup for the security server
                Backup result = apiInstance.UploadBackup(ignoreWarnings, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BackupsApi.UploadBackup: " + e.Message );
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
 **ignoreWarnings** | **bool?**| If true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail. | [optional] [default to false]
 **file** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

[**Backup**](Backup.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | item created |  -  |
| **202** | item accepted |  -  |
| **400** | request was invalid |  -  |
| **401** | authentication credentials are missing |  -  |
| **403** | request has been refused |  -  |
| **404** | resource requested does not exists |  -  |
| **406** | request specified an invalid format |  -  |
| **409** | an existing item already exists |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

