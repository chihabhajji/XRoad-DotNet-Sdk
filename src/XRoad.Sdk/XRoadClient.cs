using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XRoad.Sdk.Models;

// ReSharper disable MemberCanBeProtected.Global

namespace XRoad.Sdk;

/// <summary>
/// XRoad Client compatible with Xroad 7.0.2
/// </summary>
[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class XRoadClient : IXRoadClient
{
    private string _baseUrl = "/api/v1";
    private readonly HttpClient _httpClient;
    private Lazy<JsonSerializerSettings> _settings;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="httpClient"></param>
    public XRoadClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _settings = new Lazy<JsonSerializerSettings>(CreateSerializerSettings);
    }

    private JsonSerializerSettings CreateSerializerSettings()
    {
        var settings = new JsonSerializerSettings();
        UpdateJsonSerializerSettings(settings);
        return settings;
    }

    public string ApiKey;

    /// <summary>
    /// 
    /// </summary>
    public string BaseUrl
    {
        get => _baseUrl;
        set => _baseUrl = value;
    }

    protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

    private void ProcessResponse(HttpClient client, HttpResponseMessage response)
    {
        // Override
    }

    private void UpdateJsonSerializerSettings(JsonSerializerSettings settings)
    {
        // Override
    }

    private void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
    {
        // Override
    }

    private void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder)
    {
        // Override
    }


    /// <summary>
    /// get security server backups
    /// </summary>
    /// <returns>list of security server backups</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<Backup>> GetBackupsAsync()
    {
        return GetBackupsAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get security server backups
    /// </summary>
    /// <returns>list of security server backups</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<Backup>> GetBackupsAsync(CancellationToken cancellationToken)
    {
        var urlBuilder = new StringBuilder();
        urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/backups");

        const bool disposeClient = false;
        const bool disposeResponse_ = true;
        try
        {
            using var request = new HttpRequestMessage();
            request.Method = new HttpMethod("GET");
            request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

            PrepareRequest(_httpClient, request, urlBuilder);

            var url_ = urlBuilder.ToString();
            request.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

            PrepareRequest(_httpClient, request, url_);

            using var response_ = await _httpClient
                .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            try
            {
                var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                if (response_.Content != null && response_.Content.Headers != null)
                {
                    foreach (var (key, value) in response_.Content.Headers)
                        headers_[key] = value;
                }

                ProcessResponse(_httpClient, response_);

                var status = (int)response_.StatusCode;
                switch (status)
                {
                    case 200:
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ICollection<Backup>>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status,
                                    objectResponse_.Text, headers_, null);
                            }

                            return objectResponse_.Object;
                        }
                    case 400:
                        {
                            var responseText_ = await response_.Content.ReadAsStringAsync(cancellationToken)
                                .ConfigureAwait(false);
                            throw new ApiException("request was invalid", status, responseText_, headers_, null);
                        }
                    case 401:
                        {
                            var responseText_ = await response_.Content.ReadAsStringAsync(cancellationToken)
                                .ConfigureAwait(false);
                            throw new ApiException("authentication credentials are missing", status, responseText_,
                                headers_, null);
                        }
                    case 403:
                        {
                            var responseText_ = await response_.Content.ReadAsStringAsync(cancellationToken)
                                .ConfigureAwait(false);
                            throw new ApiException("request has been refused", status, responseText_, headers_, null);
                        }
                    case 404:
                        {
                            var responseText_ = await response_.Content.ReadAsStringAsync(cancellationToken)
                                .ConfigureAwait(false);
                            throw new ApiException("resource requested does not exists", status, responseText_, headers_,
                                null);
                        }
                    case 406:
                        {
                            string responseText_ = await response_.Content.ReadAsStringAsync(cancellationToken)
                                .ConfigureAwait(false);
                            throw new ApiException("request specified an invalid format", status, responseText_, headers_,
                                null);
                        }
                    case 500:
                        {
                            string responseText_ = await response_.Content.ReadAsStringAsync(cancellationToken)
                                .ConfigureAwait(false);
                            throw new ApiException("internal server error", status, responseText_, headers_, null);
                        }
                    default:
                        {
                            var responseData_ = await response_.Content.ReadAsStringAsync(cancellationToken)
                                .ConfigureAwait(false);
                            throw new ApiException(
                                "The HTTP status code of the response was not expected (" + status + ").", status,
                                responseData_, headers_, null);
                        }
                }
            }
            finally
            {
                if (disposeResponse_)
                    response_.Dispose();
            }
        }
        finally
        {
            if (disposeClient)
                _httpClient.Dispose();
        }
    }

    /// <summary>
    /// add new backup for the security server
    /// </summary>
    /// <returns>item created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Backup> AddBackupAsync()
    {
        return AddBackupAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add new backup for the security server
    /// </summary>
    /// <returns>item created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Backup> AddBackupAsync(CancellationToken cancellationToken)
    {
        var urlBuilder = new StringBuilder();
        urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/backups");

        var disposeClient_ = false;
        try
        {
            using var request_ = new HttpRequestMessage();
            request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
            request_.Method = new HttpMethod("POST");
            request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

            PrepareRequest(_httpClient, request_, urlBuilder);

            var url_ = urlBuilder.ToString();
            request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

            PrepareRequest(_httpClient, request_, url_);

            using var response_ = await _httpClient
                .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            const bool disposeResponse = true;
            try
            {
                var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                if (response_.Content != null && response_.Content.Headers != null)
                {
                    foreach (var item_ in response_.Content.Headers)
                        headers_[item_.Key] = item_.Value;
                }

                ProcessResponse(_httpClient, response_);

                var status_ = (int)response_.StatusCode;
                switch (status_)
                {
                    case 201:
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<Backup>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            }

                            return objectResponse_.Object;
                        }
                    case 202:
                        {
                            string responseText_ = (response_.Content == null)
                                ? string.Empty
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("item accepted", status_, responseText_, headers_, null);
                        }
                    case 400:
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            }

                            throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                    case 401:
                        {
                            string responseText_ = (response_.Content == null)
                                ? string.Empty
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("authentication credentials are missing", status_, responseText_,
                                headers_, null);
                        }
                    case 403:
                        {
                            string responseText_ = (response_.Content == null)
                                ? string.Empty
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                        }
                    case 404:
                        {
                            string responseText_ = (response_.Content == null)
                                ? string.Empty
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                                null);
                        }
                    case 406:
                        {
                            string responseText_ = (response_.Content == null)
                                ? string.Empty
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                                null);
                        }
                    case 409:
                        {
                            string responseText_ = (response_.Content == null)
                                ? string.Empty
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                                null);
                        }
                    case 500:
                        {
                            string responseText_ = (response_.Content == null)
                                ? string.Empty
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("internal server error", status_, responseText_, headers_, null);
                        }
                    default:
                        {
                            var responseData_ = response_.Content == null
                                ? null
                                : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException(
                                "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                                responseData_, headers_, null);
                        }
                }
            }
            finally
            {
                if (disposeResponse)
                    response_.Dispose();
            }
        }
        finally
        {
            if (disposeClient_)
                _httpClient.Dispose();
        }
    }

    /// <summary>
    /// add new backup for the security server and return extra backup state
    /// </summary>
    /// <returns>item created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<BackupExt> AddBackupExtAsync()
    {
        return AddBackupExtAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add new backup for the security server and return extra backup state
    /// </summary>
    /// <returns>item created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<BackupExt> AddBackupExtAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/backups/ext");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<BackupExt>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 202)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("item accepted", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// upload new backup for the security server
    /// </summary>
    /// <param name="ignore_warnings">If true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail.</param>
    /// <param name="body">backup to add</param>
    /// <returns>item created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Backup> UploadBackupAsync(bool? ignore_warnings, Stream body)
    {
        return UploadBackupAsync(ignore_warnings, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// upload new backup for the security server
    /// </summary>
    /// <param name="ignore_warnings">If true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail.</param>
    /// <param name="body">backup to add</param>
    /// <returns>item created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Backup> UploadBackupAsync(bool? ignore_warnings, Stream body,
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/backups/upload?");
        if (ignore_warnings != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("ignore_warnings") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(ignore_warnings, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StreamContent(body);
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Backup>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 202)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("item accepted", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete security server backup
    /// </summary>
    /// <param name="filename">filename of the backup</param>
    /// <returns>deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteBackupAsync(string filename)
    {
        return DeleteBackupAsync(filename, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete security server backup
    /// </summary>
    /// <param name="filename">filename of the backup</param>
    /// <returns>deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteBackupAsync(string filename, CancellationToken cancellationToken)
    {
        if (filename == null)
            throw new ArgumentNullException("filename");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/backups/{filename}");
        urlBuilder_.Replace("{filename}",
            Uri.EscapeDataString(ConvertToString(filename, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// restore security server configuration from backup
    /// </summary>
    /// <param name="filename">filename of the backup</param>
    /// <returns>restore was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<TokensLoggedOut> RestoreBackupAsync(string filename)
    {
        return RestoreBackupAsync(filename, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// restore security server configuration from backup
    /// </summary>
    /// <param name="filename">filename of the backup</param>
    /// <returns>restore was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<TokensLoggedOut> RestoreBackupAsync(string filename, CancellationToken cancellationToken)
    {
        if (filename == null)
            throw new ArgumentNullException("filename");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/backups/{filename}/restore");
        urlBuilder_.Replace("{filename}",
            Uri.EscapeDataString(ConvertToString(filename, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<TokensLoggedOut>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// download security server backup
    /// </summary>
    /// <param name="filename">filename of the backup</param>
    /// <returns>backup file downloaded</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<FileResponse> DownloadBackupAsync(string filename)
    {
        return DownloadBackupAsync(filename, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// download security server backup
    /// </summary>
    /// <param name="filename">filename of the backup</param>
    /// <returns>backup file downloaded</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> DownloadBackupAsync(string filename, CancellationToken cancellationToken)
    {
        if (filename == null)
            throw new ArgumentNullException("filename");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/backups/{filename}/download");
        urlBuilder_.Replace("{filename}",
            Uri.EscapeDataString(ConvertToString(filename, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200 || status_ == 206)
                    {
                        var responseStream_ = response_.Content == null
                            ? Stream.Null
                            : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                        var fileResponse_ = new FileResponse(status_, headers_, responseStream_, null, response_);
                        disposeClient_ = false;
                        disposeResponse_ = false; // response and client are disposed by FileResponse
                        return fileResponse_;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// import new certificate
    /// </summary>
    /// <param name="body">certificate to import</param>
    /// <returns>certificate created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<TokenCertificate> ImportCertificateAsync(Stream body)
    {
        return ImportCertificateAsync(body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// import new certificate
    /// </summary>
    /// <param name="body">certificate to import</param>
    /// <returns>certificate created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<TokenCertificate> ImportCertificateAsync(Stream body, CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/token-certificates");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StreamContent(body);
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<TokenCertificate>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get certificate information
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>token certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<TokenCertificate> GetCertificateAsync(string hash)
    {
        return GetCertificateAsync(hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get certificate information
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>token certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<TokenCertificate> GetCertificateAsync(string hash, CancellationToken cancellationToken)
    {
        if (hash == null)
            throw new ArgumentNullException("hash");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/token-certificates/{hash}");
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<TokenCertificate>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteCertificateAsync(string hash)
    {
        return DeleteCertificateAsync(hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteCertificateAsync(string hash, CancellationToken cancellationToken)
    {
        if (hash == null)
            throw new ArgumentNullException("hash");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/token-certificates/{hash}");
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// activate certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>request was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task ActivateCertificateAsync(string hash)
    {
        return ActivateCertificateAsync(hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// activate certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>request was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task ActivateCertificateAsync(string hash, CancellationToken cancellationToken)
    {
        if (hash == null)
            throw new ArgumentNullException("hash");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/token-certificates/{hash}/activate");
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// deactivate certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>certificate was deactivated</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DisableCertificateAsync(string hash)
    {
        return DisableCertificateAsync(hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// deactivate certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>certificate was deactivated</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DisableCertificateAsync(string hash, CancellationToken cancellationToken)
    {
        if (hash == null)
            throw new ArgumentNullException("hash");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/token-certificates/{hash}/disable");
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// import an existing certificate from a token by cert hash
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>the imported certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<TokenCertificate> ImportCertificateFromTokenAsync(string hash)
    {
        return ImportCertificateFromTokenAsync(hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// import an existing certificate from a token by cert hash
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>the imported certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<TokenCertificate> ImportCertificateFromTokenAsync(string hash,
        CancellationToken cancellationToken)
    {
        if (hash == null)
            throw new ArgumentNullException("hash");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/token-certificates/{hash}/import");
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<TokenCertificate>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get possible actions for one certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>possible actions that can be done on the certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<PossibleAction>> GetPossibleActionsForCertificateAsync(string hash)
    {
        return GetPossibleActionsForCertificateAsync(hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get possible actions for one certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>possible actions that can be done on the certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<PossibleAction>> GetPossibleActionsForCertificateAsync(string hash,
        CancellationToken cancellationToken)
    {
        if (hash == null)
            throw new ArgumentNullException("hash");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/token-certificates/{hash}/possible-actions");
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using var request_ = new HttpRequestMessage();
            request_.Method = new HttpMethod("GET");
            request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

            PrepareRequest(client_, request_, urlBuilder_);

            var url_ = urlBuilder_.ToString();
            request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

            PrepareRequest(client_, request_, url_);

            var response_ = await client_
                .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            var disposeResponse_ = true;
            try
            {
                var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                if (response_.Content != null && response_.Content.Headers != null)
                {
                    foreach (var item_ in response_.Content.Headers)
                        headers_[item_.Key] = item_.Value;
                }

                ProcessResponse(client_, response_);

                var status_ = (int)response_.StatusCode;
                if (status_ == 200)
                {
                    var objectResponse_ =
                        await ReadObjectResponseAsync<ICollection<PossibleAction>>(response_, headers_,
                            cancellationToken).ConfigureAwait(false);
                    if (objectResponse_.Object == null)
                    {
                        throw new ApiException("Response was null which was not expected.", status_,
                            objectResponse_.Text, headers_, null);
                    }

                    return objectResponse_.Object;
                }
                else if (status_ == 400)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                }
                else if (status_ == 401)
                {
                    var responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("authentication credentials are missing", status_, responseText_, headers_,
                        null);
                }
                else if (status_ == 403)
                {
                    var responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                }
                else if (status_ == 404)
                {
                    var responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                        null);
                }
                else if (status_ == 406)
                {
                    var responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                        null);
                }
                else if (status_ == 500)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("internal server error", status_, responseText_, headers_, null);
                }
                else
                {
                    var responseData_ = response_.Content == null
                        ? null
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").",
                        status_, responseData_, headers_, null);
                }
            }
            finally
            {
                response_.Dispose();
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// register certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>request was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task RegisterCertificateAsync(string hash, SecurityServerAddress body)
    {
        return RegisterCertificateAsync(hash, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// register certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>request was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task RegisterCertificateAsync(string hash, SecurityServerAddress body,
        CancellationToken cancellationToken)
    {
        if (hash == null)
            throw new ArgumentNullException(nameof(hash));

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/token-certificates/{hash}/register");
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        const bool disposeClient = false;
        try
        {
            using var request_ = new HttpRequestMessage();
            var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
            content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            request_.Content = content_;
            request_.Method = new HttpMethod("PUT");

            PrepareRequest(_httpClient, request_, urlBuilder_);

            var url = urlBuilder_.ToString();
            request_.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

            PrepareRequest(_httpClient, request_, url);

            using var response_ = await _httpClient
                .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            var disposeResponse_ = true;
            try
            {
                var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                if (response_.Content != null && response_.Content.Headers != null)
                {
                    foreach (var item_ in response_.Content.Headers)
                        headers_[item_.Key] = item_.Value;
                }

                ProcessResponse(_httpClient, response_);

                var status_ = (int)response_.StatusCode;
                if (status_ == 200)
                {
                }
                else if (status_ == 400)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                }
                else if (status_ == 401)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("authentication credentials are missing", status_, responseText_, headers_,
                        null);
                }
                else if (status_ == 403)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                }
                else if (status_ == 404)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                        null);
                }
                else if (status_ == 406)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                        null);
                }
                else if (status_ == 500)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("internal server error", status_, responseText_, headers_, null);
                }
                else
                {
                    var responseData_ = response_.Content == null
                        ? null
                        : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").",
                        status_, responseData_, headers_, null);
                }
            }
            finally
            {
                if (disposeResponse_)
                    response_.Dispose();
            }
        }
        finally
        {
            if (disposeClient)
                _httpClient.Dispose();
        }
    }

    /// <summary>
    /// unregister authentication certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>request was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task UnregisterAuthCertificateAsync(string hash)
    {
        return UnregisterAuthCertificateAsync(hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// unregister authentication certificate
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>request was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task UnregisterAuthCertificateAsync(string hash, CancellationToken cancellationToken)
    {
        if (hash == null)
            throw new ArgumentNullException(nameof(hash));

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/token-certificates/{hash}/unregister");
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("internal server error", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// marks an auth certificate for deletion
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>request was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task MarkAuthCertForDeletionAsync(string hash)
    {
        return MarkAuthCertForDeletionAsync(hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// marks an auth certificate for deletion
    /// </summary>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>request was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task MarkAuthCertForDeletionAsync(string hash, CancellationToken cancellationToken)
    {
        if (hash == null)
            throw new ArgumentNullException("hash");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/token-certificates/{hash}/mark-for-deletion");
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("internal server error", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// find security server clients
    /// </summary>
    /// <param name="name">pass an optional search string (name) for looking up clients</param>
    /// <param name="instance">pass an optional search string (instance) for looking up clients</param>
    /// <param name="member_class">pass an optional search string (member_class) for looking up clients</param>
    /// <param name="member_code">pass an optional search string (member_code) for looking up clients</param>
    /// <param name="subsystem_code">pass an optional search string (subsystem_code) for looking up clients</param>
    /// <param name="show_members">to include members for search results</param>
    /// <param name="internal_search">to search only clients inside security server</param>
    /// <param name="local_valid_sign_cert">To search only clients that have (or don't have) a valid (registered, OCSP response GOOD) sign cert stored on this security server. Can be used to search both local and global clients, and can be combined with &lt;code&gt;internal_search&lt;/code&gt; and &lt;code&gt;exclude_local&lt;/code&gt; parameters. True = limit to clients that have a valid local sign cert, false = limit to clients that don't have a valid local sign cert.</param>
    /// <param name="exclude_local">to search only clients that are not added to this security server</param>
    /// <returns>list of clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<Client>> FindClientsAsync(string? name, string? instance, string? member_class,
        string? member_code, string subsystem_code, bool? show_members, bool? internal_search,
        bool? local_valid_sign_cert, bool? exclude_local)
    {
        return FindClientsAsync(name, instance, member_class, member_code, subsystem_code, show_members,
            internal_search, local_valid_sign_cert, exclude_local, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// find security server clients
    /// </summary>
    /// <param name="name">pass an optional search string (name) for looking up clients</param>
    /// <param name="instance">pass an optional search string (instance) for looking up clients</param>
    /// <param name="member_class">pass an optional search string (member_class) for looking up clients</param>
    /// <param name="member_code">pass an optional search string (member_code) for looking up clients</param>
    /// <param name="subsystem_code">pass an optional search string (subsystem_code) for looking up clients</param>
    /// <param name="show_members">to include members for search results</param>
    /// <param name="internal_search">to search only clients inside security server</param>
    /// <param name="local_valid_sign_cert">To search only clients that have (or don't have) a valid (registered, OCSP response GOOD) sign cert stored on this security server. Can be used to search both local and global clients, and can be combined with &lt;code&gt;internal_search&lt;/code&gt; and &lt;code&gt;exclude_local&lt;/code&gt; parameters. True = limit to clients that have a valid local sign cert, false = limit to clients that don't have a valid local sign cert.</param>
    /// <param name="exclude_local">to search only clients that are not added to this security server</param>
    /// <returns>list of clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<Client>> FindClientsAsync(string? name, string? instance, string? member_class,
        string? member_code, string? subsystem_code, bool? show_members, bool? internal_search,
        bool? local_valid_sign_cert, bool? exclude_local, CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients?");
        if (name != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("name") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture))).Append("&");
        }

        if (instance != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("instance") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(instance, CultureInfo.InvariantCulture))).Append("&");
        }

        if (member_class != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("member_class") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(member_class, CultureInfo.InvariantCulture))).Append("&");
        }

        if (member_code != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("member_code") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(member_code, CultureInfo.InvariantCulture))).Append("&");
        }

        if (subsystem_code != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("subsystem_code") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(subsystem_code, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        if (show_members != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("show_members") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(show_members, CultureInfo.InvariantCulture))).Append("&");
        }

        if (internal_search != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("internal_search") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(internal_search, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        if (local_valid_sign_cert != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("local_valid_sign_cert") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(local_valid_sign_cert, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        if (exclude_local != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("exclude_local") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(exclude_local, CultureInfo.InvariantCulture))).Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using var request_ = new HttpRequestMessage();
            request_.Method = new HttpMethod("GET");
            request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

            PrepareRequest(client_, request_, urlBuilder_);

            var url_ = urlBuilder_.ToString();
            request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

            PrepareRequest(client_, request_, url_);

            var response_ = await client_
                .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                .ConfigureAwait(false);
            var disposeResponse_ = true;
            try
            {
                var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                if (response_.Content != null && response_.Content.Headers != null)
                {
                    foreach (var item_ in response_.Content.Headers)
                        headers_[item_.Key] = item_.Value;
                }

                ProcessResponse(client_, response_);

                var status_ = (int)response_.StatusCode;
                if (status_ == 200)
                {
                    var objectResponse_ =
                        await ReadObjectResponseAsync<ICollection<Client>>(response_, headers_, cancellationToken)
                            .ConfigureAwait(false);
                    if (objectResponse_.Object == null)
                    {
                        throw new ApiException("Response was null which was not expected.", status_,
                            objectResponse_.Text, headers_, null);
                    }

                    return objectResponse_.Object;
                }
                else if (status_ == 400)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                }
                else if (status_ == 401)
                {
                    var responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("authentication credentials are missing", status_, responseText_,
                        headers_, null);
                }
                else if (status_ == 403)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                }
                else if (status_ == 404)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                        null);
                }
                else if (status_ == 406)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                        null);
                }
                else if (status_ == 500)
                {
                    string responseText_ = (response_.Content == null)
                        ? string.Empty
                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("internal server error", status_, responseText_, headers_, null);
                }
                else
                {
                    var responseData_ = response_.Content == null
                        ? null
                        : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException(
                        "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                        responseData_, headers_, null);
                }
            }
            finally
            {
                if (disposeResponse_)
                    response_.Dispose();
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Add new client for the security server.
    /// </summary>
    /// <param name="body">client to add</param>
    /// <returns>new client created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Client> AddClientAsync(ClientAdd body)
    {
        return AddClientAsync(body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Add new client for the security server.
    /// </summary>
    /// <param name="body">client to add</param>
    /// <returns>new client created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Client> AddClientAsync(ClientAdd body, CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Client>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>(
                            "there are warnings or errors related to the service description", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get security server client information
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>client object</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Client> GetClientAsync(string id)
    {
        return GetClientAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get security server client information
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>client object</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Client> GetClientAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Client>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// update security server client information
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>client modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Client> UpdateClientAsync(string id, ConnectionTypeWrapper body)
    {
        return UpdateClientAsync(id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// update security server client information
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>client modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Client> UpdateClientAsync(string id, ConnectionTypeWrapper body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PATCH");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Client>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>client deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteClientAsync(string id)
    {
        return DeleteClientAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>client deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteClientAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get local groups for the selected client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of local groups</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<LocalGroup>> GetClientLocalGroupsAsync(string id)
    {
        return GetClientLocalGroupsAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get local groups for the selected client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of local groups</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<LocalGroup>> GetClientLocalGroupsAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/local-groups");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<LocalGroup>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// add new local group for the security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="body">group to add</param>
    /// <returns>local group created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<LocalGroup> AddClientLocalGroupAsync(string id, LocalGroupAdd body)
    {
        return AddClientLocalGroupAsync(id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add new local group for the security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="body">group to add</param>
    /// <returns>local group created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<LocalGroup> AddClientLocalGroupAsync(string id, LocalGroupAdd body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/local-groups");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<LocalGroup>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get information about orphaned sign keys, certificates and csrs left behind a delete client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>Information telling that orphans exist. If they don't exist, 404 is returned instead.</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<OrphanInformation> GetClientOrphansAsync(string id)
    {
        return GetClientOrphansAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get information about orphaned sign keys, certificates and csrs left behind a delete client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>Information telling that orphans exist. If they don't exist, 404 is returned instead.</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<OrphanInformation> GetClientOrphansAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/orphans");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<OrphanInformation>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("internal server error", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete orphaned sign keys, certificates and csrs left behind a delete client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteOrphansAsync(string id)
    {
        return DeleteOrphansAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete orphaned sign keys, certificates and csrs left behind a delete client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteOrphansAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/orphans");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// register security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>client was registered</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task RegisterClientAsync(string id)
    {
        return RegisterClientAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// register security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>client was registered</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task RegisterClientAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/register");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("internal server error", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get service clients for the selected client's services
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of service clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<ServiceClient>> GetClientServiceClientsAsync(string id)
    {
        return GetClientServiceClientsAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get service clients for the selected client's services
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of service clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<ServiceClient>> GetClientServiceClientsAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/service-clients");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<ServiceClient>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get single service client by client id and service client id
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="sc_id">id of the service client</param>
    /// <returns>single service clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ServiceClient> GetServiceClientAsync(string id, string sc_id)
    {
        return GetServiceClientAsync(id, sc_id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get single service client by client id and service client id
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="sc_id">id of the service client</param>
    /// <returns>single service clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ServiceClient> GetServiceClientAsync(string id, string sc_id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        if (sc_id == null)
            throw new ArgumentNullException("sc_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/service-clients/{sc_id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        urlBuilder_.Replace("{sc_id}", Uri.EscapeDataString(ConvertToString(sc_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ServiceClient>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get access rights for the selected service client.
    /// </summary>
    /// <param name="id">id of the client who owns the services</param>
    /// <param name="sc_id">id of the service client</param>
    /// <returns>list of access rights</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<AccessRight>> GetServiceClientAccessRightsAsync(string id, string sc_id)
    {
        return GetServiceClientAccessRightsAsync(id, sc_id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get access rights for the selected service client.
    /// </summary>
    /// <param name="id">id of the client who owns the services</param>
    /// <param name="sc_id">id of the service client</param>
    /// <returns>list of access rights</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<AccessRight>> GetServiceClientAccessRightsAsync(string id, string sc_id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        if (sc_id == null)
            throw new ArgumentNullException("sc_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/clients/{id}/service-clients/{sc_id}/access-rights");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        urlBuilder_.Replace("{sc_id}", Uri.EscapeDataString(ConvertToString(sc_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<AccessRight>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Add new access rights for selected service client. If service client did not exist yet, one is created.
    /// </summary>
    /// <param name="id">id of the client who owns the services</param>
    /// <param name="sc_id">id of the service client</param>
    /// <returns>access right that was added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<AccessRight>> AddServiceClientAccessRightsAsync(string id, string sc_id,
        AccessRights body)
    {
        return AddServiceClientAccessRightsAsync(id, sc_id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Add new access rights for selected service client. If service client did not exist yet, one is created.
    /// </summary>
    /// <param name="id">id of the client who owns the services</param>
    /// <param name="sc_id">id of the service client</param>
    /// <returns>access right that was added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<AccessRight>> AddServiceClientAccessRightsAsync(string id, string sc_id,
        AccessRights body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        if (sc_id == null)
            throw new ArgumentNullException("sc_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/clients/{id}/service-clients/{sc_id}/access-rights");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        urlBuilder_.Replace("{sc_id}", Uri.EscapeDataString(ConvertToString(sc_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<AccessRight>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// remove access rights
    /// </summary>
    /// <param name="id">id of the client who owns the services</param>
    /// <param name="sc_id">id of the service client</param>
    /// <param name="body">list of access rights to be deleted</param>
    /// <returns>access right(s) deleted</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteServiceClientAccessRightsAsync(string id, string sc_id, AccessRights body)
    {
        return DeleteServiceClientAccessRightsAsync(id, sc_id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// remove access rights
    /// </summary>
    /// <param name="id">id of the client who owns the services</param>
    /// <param name="sc_id">id of the service client</param>
    /// <param name="body">list of access rights to be deleted</param>
    /// <returns>access right(s) deleted</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteServiceClientAccessRightsAsync(string id, string sc_id, AccessRights body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        if (sc_id == null)
            throw new ArgumentNullException("sc_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/clients/{id}/service-clients/{sc_id}/access-rights/delete");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        urlBuilder_.Replace("{sc_id}", Uri.EscapeDataString(ConvertToString(sc_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get security server client certificates information
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of certificates</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<TokenCertificate>> GetClientSignCertificatesAsync(string id)
    {
        return GetClientSignCertificatesAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get security server client certificates information
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of certificates</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<TokenCertificate>> GetClientSignCertificatesAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/sign-certificates");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<TokenCertificate>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get security server client TLS certificates information
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of tls certificates</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<CertificateDetails>> GetClientTlsCertificatesAsync(string id)
    {
        return GetClientTlsCertificatesAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get security server client TLS certificates information
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of tls certificates</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<CertificateDetails>> GetClientTlsCertificatesAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/tls-certificates");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<CertificateDetails>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// add new certificate for the security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="body">certificate to add</param>
    /// <returns>certificate added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<CertificateDetails> AddClientTlsCertificateAsync(string id, Stream body)
    {
        return AddClientTlsCertificateAsync(id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add new certificate for the security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="body">certificate to add</param>
    /// <returns>certificate added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<CertificateDetails> AddClientTlsCertificateAsync(string id, Stream body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/tls-certificates");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StreamContent(body);
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<CertificateDetails>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get TLS certificate
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>certificate details</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<CertificateDetails> GetClientTlsCertificateAsync(string id, string hash)
    {
        return GetClientTlsCertificateAsync(id, hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get TLS certificate
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>certificate details</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<CertificateDetails> GetClientTlsCertificateAsync(string id, string hash,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        if (hash == null)
            throw new ArgumentNullException("hash");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/tls-certificates/{hash}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<CertificateDetails>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete certificate
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>certificate deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteClientTlsCertificateAsync(string id, string hash)
    {
        return DeleteClientTlsCertificateAsync(id, hash, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete certificate
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="hash">SHA-1 hash of the certificate</param>
    /// <returns>certificate deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteClientTlsCertificateAsync(string id, string hash,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        if (hash == null)
            throw new ArgumentNullException("hash");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/tls-certificates/{hash}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        urlBuilder_.Replace("{hash}", Uri.EscapeDataString(ConvertToString(hash, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// unregister security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>unregister was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task UnregisterClientAsync(string id)
    {
        return UnregisterClientAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// unregister security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>unregister was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task UnregisterClientAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/unregister");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("internal server error", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get security server client service descriptions
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of service descriptions</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<ServiceDescription>> GetClientServiceDescriptionsAsync(string id)
    {
        return GetClientServiceDescriptionsAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get security server client service descriptions
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>list of service descriptions</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<ServiceDescription>> GetClientServiceDescriptionsAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/service-descriptions");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<ServiceDescription>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("an existing item already exists", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// add new service description for the security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>service description created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ServiceDescription> AddClientServiceDescriptionAsync(string id, ServiceDescriptionAdd body)
    {
        return AddClientServiceDescriptionAsync(id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add new service description for the security server client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <returns>service description created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ServiceDescription> AddClientServiceDescriptionAsync(string id,
        ServiceDescriptionAdd body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/service-descriptions");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ServiceDescription>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>(
                            "there are warnings or errors related to the service description", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>(
                            "<h3>An existing item already exists</h3> <p> If there are existing WSDL services with the same name, the error response will include the existing services\' names and the containing WSDL\'s URL in the metadata array. </p> <p> In this case the error code <code>service_already_exists</code> (WSDL) or <code>service_code_already_exists</code> (OPENAPI3) is used and the entries in the metadata array are ordered in following way <ul> <li>metadata has a list of strings [C1,U1,C2,U2....Cn,Un] where</li> <li>C1 = duplicate service full code</li> <li>U1 = URL of the existing WSDL that has the duplicate</li> </ul> </p> <strong>See the example</strong>",
                            status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// find ServiceClient candidates for a specific client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="member_name_group_description">pass an optional search string (name) for looking up subjects - name of a member or description of a group</param>
    /// <param name="service_client_type">pass an optional search string (service_client_type) for looking up service clients</param>
    /// <param name="instance">pass an optional search string (instance) for looking up service clients - full instance id should be used</param>
    /// <param name="member_class">pass an optional search string (member_class) for looking up service clients</param>
    /// <param name="member_group_code">pass an optional search string (member_group_code) for looking up service clients - member_code of a member or group_code of a group</param>
    /// <param name="subsystem_code">pass an optional search string (subsystem_code) for looking up service clients</param>
    /// <returns>list of service clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<ServiceClient>> FindServiceClientCandidatesAsync(string id,
        string member_name_group_description, ServiceClientType? service_client_type, string instance,
        string member_class, string member_group_code, string subsystem_code)
    {
        return FindServiceClientCandidatesAsync(id, member_name_group_description, service_client_type, instance,
            member_class, member_group_code, subsystem_code, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// find ServiceClient candidates for a specific client
    /// </summary>
    /// <param name="id">id of the client</param>
    /// <param name="member_name_group_description">pass an optional search string (name) for looking up subjects - name of a member or description of a group</param>
    /// <param name="service_client_type">pass an optional search string (service_client_type) for looking up service clients</param>
    /// <param name="instance">pass an optional search string (instance) for looking up service clients - full instance id should be used</param>
    /// <param name="member_class">pass an optional search string (member_class) for looking up service clients</param>
    /// <param name="member_group_code">pass an optional search string (member_group_code) for looking up service clients - member_code of a member or group_code of a group</param>
    /// <param name="subsystem_code">pass an optional search string (subsystem_code) for looking up service clients</param>
    /// <returns>list of service clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<ServiceClient>> FindServiceClientCandidatesAsync(string id,
        string member_name_group_description, ServiceClientType? service_client_type, string instance,
        string member_class, string member_group_code, string subsystem_code, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/clients/{id}/service-client-candidates?");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        if (member_name_group_description != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("member_name_group_description") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(member_name_group_description,
                    CultureInfo.InvariantCulture))).Append("&");
        }

        if (service_client_type != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("service_client_type") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(service_client_type, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        if (instance != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("instance") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(instance, CultureInfo.InvariantCulture))).Append("&");
        }

        if (member_class != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("member_class") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(member_class, CultureInfo.InvariantCulture))).Append("&");
        }

        if (member_group_code != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("member_group_code") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(member_group_code, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        if (subsystem_code != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("subsystem_code") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(subsystem_code, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<ServiceClient>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// make client Security Server's owner. Client must be a member and already registered on the Security Server
    /// </summary>
    /// <param name="id">id of the client to be set as owner</param>
    /// <returns>client was set as owner</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task ChangeOwnerAsync(string id)
    {
        return ChangeOwnerAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// make client Security Server's owner. Client must be a member and already registered on the Security Server
    /// </summary>
    /// <param name="id">id of the client to be set as owner</param>
    /// <returns>client was set as owner</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task ChangeOwnerAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients/{id}/make-owner");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("internal server error", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// view global configuration diagnostics information
    /// </summary>
    /// <returns>global configuration diagnostics information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<GlobalConfDiagnostics> GetGlobalConfDiagnosticsAsync()
    {
        return GetGlobalConfDiagnosticsAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// view global configuration diagnostics information
    /// </summary>
    /// <returns>global configuration diagnostics information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<GlobalConfDiagnostics> GetGlobalConfDiagnosticsAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/diagnostics/globalconf");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<GlobalConfDiagnostics>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// view ocsp responders diagnostics information
    /// </summary>
    /// <returns>ocsp responders diagnostics information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<OcspResponderDiagnostics>> GetOcspRespondersDiagnosticsAsync()
    {
        return GetOcspRespondersDiagnosticsAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// view ocsp responders diagnostics information
    /// </summary>
    /// <returns>ocsp responders diagnostics information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<OcspResponderDiagnostics>> GetOcspRespondersDiagnosticsAsync(
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/diagnostics/ocsp-responders");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<OcspResponderDiagnostics>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// view timestamping services diagnostics information
    /// </summary>
    /// <returns>timestamping services diagnostics information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<TimestampingServiceDiagnostics>> GetTimestampingServicesDiagnosticsAsync()
    {
        return GetTimestampingServicesDiagnosticsAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// view timestamping services diagnostics information
    /// </summary>
    /// <returns>timestamping services diagnostics information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<TimestampingServiceDiagnostics>> GetTimestampingServicesDiagnosticsAsync(
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/diagnostics/timestamping-services");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<TimestampingServiceDiagnostics>>(response_,
                                headers_, cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Initialize a new security server with the provided initial configuration
    /// </summary>
    /// <param name="body">initial security server configuration</param>
    /// <returns>security server initialized</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task InitSecurityServerAsync(InitialServerConf body)
    {
        return InitSecurityServerAsync(body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Initialize a new security server with the provided initial configuration
    /// </summary>
    /// <param name="body">initial security server configuration</param>
    /// <returns>security server initialized</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task InitSecurityServerAsync(InitialServerConf body, CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/initialization");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Check the initialization status of the Security Server
    /// </summary>
    /// <returns>initialization status of the Security Server</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<InitializationStatus> GetInitializationStatusAsync()
    {
        return GetInitializationStatusAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Check the initialization status of the Security Server
    /// </summary>
    /// <returns>initialization status of the Security Server</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<InitializationStatus> GetInitializationStatusAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/initialization/status");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<InitializationStatus>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get local group information
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>group object</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<LocalGroup> GetLocalGroupAsync(string group_id)
    {
        return GetLocalGroupAsync(group_id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get local group information
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>group object</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<LocalGroup> GetLocalGroupAsync(string group_id, CancellationToken cancellationToken)
    {
        if (group_id == null)
            throw new ArgumentNullException("group_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/local-groups/{group_id}");
        urlBuilder_.Replace("{group_id}",
            Uri.EscapeDataString(ConvertToString(group_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<LocalGroup>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// update local group information
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>local group modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<LocalGroup> UpdateLocalGroupAsync(string group_id, LocalGroupDescription body)
    {
        return UpdateLocalGroupAsync(group_id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// update local group information
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>local group modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<LocalGroup> UpdateLocalGroupAsync(string group_id, LocalGroupDescription body,
        CancellationToken cancellationToken)
    {
        if (group_id == null)
            throw new ArgumentNullException("group_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/local-groups/{group_id}");
        urlBuilder_.Replace("{group_id}",
            Uri.EscapeDataString(ConvertToString(group_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PATCH");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<LocalGroup>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete local group
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>local group deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteLocalGroupAsync(string group_id)
    {
        return DeleteLocalGroupAsync(group_id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete local group
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>local group deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteLocalGroupAsync(string group_id, CancellationToken cancellationToken)
    {
        if (group_id == null)
            throw new ArgumentNullException("group_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/local-groups/{group_id}");
        urlBuilder_.Replace("{group_id}",
            Uri.EscapeDataString(ConvertToString(group_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// add new member for the local group
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>new members added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Members> AddLocalGroupMemberAsync(string group_id, Members body)
    {
        return AddLocalGroupMemberAsync(group_id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add new member for the local group
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>new members added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Members> AddLocalGroupMemberAsync(string group_id, Members body,
        CancellationToken cancellationToken)
    {
        if (group_id == null)
            throw new ArgumentNullException("group_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/local-groups/{group_id}/members");
        urlBuilder_.Replace("{group_id}",
            Uri.EscapeDataString(ConvertToString(group_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Members>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete member from local group
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>members deleted</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteLocalGroupMemberAsync(string group_id, Members body)
    {
        return DeleteLocalGroupMemberAsync(group_id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete member from local group
    /// </summary>
    /// <param name="group_id">id of the local group</param>
    /// <returns>members deleted</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteLocalGroupMemberAsync(string group_id, Members body,
        CancellationToken cancellationToken)
    {
        if (group_id == null)
            throw new ArgumentNullException("group_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/local-groups/{group_id}/members/delete");
        urlBuilder_.Replace("{group_id}",
            Uri.EscapeDataString(ConvertToString(group_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get information for the selected key in selected token
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <returns>key object</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Key> GetKeyAsync(string id)
    {
        return GetKeyAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get information for the selected key in selected token
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <returns>key object</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Key> GetKeyAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/keys/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<Key>(response_, headers_, cancellationToken)
                            .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// update key information
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <returns>key modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Key> UpdateKeyAsync(string id, KeyName body)
    {
        return UpdateKeyAsync(id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// update key information
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <returns>key modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Key> UpdateKeyAsync(string id, KeyName body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/keys/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PATCH");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<Key>(response_, headers_, cancellationToken)
                            .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        var responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        var responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete key
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="ignore_warnings">if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail</param>
    /// <returns>key deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteKeyAsync(string id, bool? ignore_warnings)
    {
        return DeleteKeyAsync(id, ignore_warnings, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete key
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="ignore_warnings">if true, any ignorable warnings are ignored. if false (or missing), any warnings cause request to fail</param>
    /// <returns>key deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteKeyAsync(string id, bool? ignore_warnings, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/keys/{id}?");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        if (ignore_warnings != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("ignore_warnings") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(ignore_warnings, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("internal server error", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// generate csr for the selected key
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="body">request to generate csr</param>
    /// <returns>created CSR</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<FileResponse> GenerateCsrAsync(string id, CsrGenerate body)
    {
        return GenerateCsrAsync(id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// generate csr for the selected key
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="body">request to generate csr</param>
    /// <returns>created CSR</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> GenerateCsrAsync(string id, CsrGenerate body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/keys/{id}/csrs");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var responseStream_ = response_.Content == null
                            ? Stream.Null
                            : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                        var fileResponse_ = new FileResponse(status_, headers_, responseStream_, null, response_);
                        disposeClient_ = false;
                        disposeResponse_ = false; // response and client are disposed by FileResponse
                        return fileResponse_;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// download a CSR binary
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="csr_id">id of the csr</param>
    /// <param name="csr_format">format of the certificate signing request (PEM or DER)</param>
    /// <returns>CSR binary</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<FileResponse> DownloadCsrAsync(string id, string csr_id, CsrFormat? csr_format)
    {
        return DownloadCsrAsync(id, csr_id, csr_format, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// download a CSR binary
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="csr_id">id of the csr</param>
    /// <param name="csr_format">format of the certificate signing request (PEM or DER)</param>
    /// <returns>CSR binary</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> DownloadCsrAsync(string id, string csr_id, CsrFormat? csr_format,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        if (csr_id == null)
            throw new ArgumentNullException("csr_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/keys/{id}/csrs/{csr_id}?");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        urlBuilder_.Replace("{csr_id}", Uri.EscapeDataString(ConvertToString(csr_id, CultureInfo.InvariantCulture)));
        if (csr_format != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("csr_format") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(csr_format, CultureInfo.InvariantCulture))).Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var responseStream_ = response_.Content == null
                            ? Stream.Null
                            : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                        var fileResponse_ = new FileResponse(status_, headers_, responseStream_, null, response_);
                        disposeClient_ = false;
                        disposeResponse_ = false; // response and client are disposed by FileResponse
                        return fileResponse_;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete csr from the selected key
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="csr_id">id of the csr</param>
    /// <returns>csr deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteCsrAsync(string id, string csr_id)
    {
        return DeleteCsrAsync(id, csr_id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete csr from the selected key
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="csr_id">id of the csr</param>
    /// <returns>csr deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteCsrAsync(string id, string csr_id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        if (csr_id == null)
            throw new ArgumentNullException("csr_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/keys/{id}/csrs/{csr_id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        urlBuilder_.Replace("{csr_id}", Uri.EscapeDataString(ConvertToString(csr_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get possible actions for one csr
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="csr_id">id of the csr</param>
    /// <returns>possible actions that can be done on the certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<PossibleAction>> GetPossibleActionsForCsrAsync(string id, string csr_id)
    {
        return GetPossibleActionsForCsrAsync(id, csr_id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get possible actions for one csr
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <param name="csr_id">id of the csr</param>
    /// <returns>possible actions that can be done on the certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<PossibleAction>> GetPossibleActionsForCsrAsync(string id, string csr_id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        if (csr_id == null)
            throw new ArgumentNullException("csr_id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/keys/{id}/csrs/{csr_id}/possible-actions");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
        urlBuilder_.Replace("{csr_id}", Uri.EscapeDataString(ConvertToString(csr_id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<PossibleAction>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get possible actions for one key
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <returns>possible actions that can be done on the certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<PossibleAction>> GetPossibleActionsForKeyAsync(string id)
    {
        return GetPossibleActionsForKeyAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get possible actions for one key
    /// </summary>
    /// <param name="id">id of the key</param>
    /// <returns>possible actions that can be done on the certificate</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<PossibleAction>> GetPossibleActionsForKeyAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/keys/{id}/possible-actions");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<PossibleAction>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get list of known member classes
    /// </summary>
    /// <param name="current_instance">if true, return member classes for this instance. if false (default), return member classes for all instances</param>
    /// <returns>array of member classes</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<string>> GetMemberClassesAsync(bool? current_instance)
    {
        return GetMemberClassesAsync(current_instance, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get list of known member classes
    /// </summary>
    /// <param name="current_instance">if true, return member classes for this instance. if false (default), return member classes for all instances</param>
    /// <returns>array of member classes</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<string>> GetMemberClassesAsync(bool? current_instance,
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/member-classes?");
        if (current_instance != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("current_instance") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(current_instance, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<string>>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get list of known member classes for a given instance
    /// </summary>
    /// <param name="id">instance id</param>
    /// <returns>array of member classes</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<string>> GetMemberClassesForInstanceAsync(string id)
    {
        return GetMemberClassesForInstanceAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get list of known member classes for a given instance
    /// </summary>
    /// <param name="id">instance id</param>
    /// <returns>array of member classes</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<string>> GetMemberClassesForInstanceAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/member-classes/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<string>>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// find member name by member class and member code
    /// </summary>
    /// <param name="member_class">class of the member</param>
    /// <param name="member_code">code of the member</param>
    /// <returns>name of the member</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<MemberName> FindMemberNameAsync(string member_class, string member_code)
    {
        return FindMemberNameAsync(member_class, member_code, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// find member name by member class and member code
    /// </summary>
    /// <param name="member_class">class of the member</param>
    /// <param name="member_code">code of the member</param>
    /// <returns>name of the member</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<MemberName> FindMemberNameAsync(string member_class, string member_code,
        CancellationToken cancellationToken)
    {
        if (member_class == null)
            throw new ArgumentNullException("member_class");

        if (member_code == null)
            throw new ArgumentNullException("member_code");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/member-names?");
        urlBuilder_.Append(Uri.EscapeDataString("member_class") + "=")
            .Append(Uri.EscapeDataString(ConvertToString(member_class, CultureInfo.InvariantCulture))).Append("&");
        urlBuilder_.Append(Uri.EscapeDataString("member_code") + "=")
            .Append(Uri.EscapeDataString(ConvertToString(member_code, CultureInfo.InvariantCulture))).Append("&");
        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<MemberName>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// change language
    /// </summary>
    /// <param name="code">code of the language (language code)</param>
    /// <returns>language changed</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Language> LanguageAsync(string code)
    {
        return LanguageAsync(code, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// change language
    /// </summary>
    /// <param name="code">code of the language (language code)</param>
    /// <returns>language changed</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Language> LanguageAsync(string code, CancellationToken cancellationToken)
    {
        if (code == null)
            throw new ArgumentNullException("code");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/language/{code}");
        urlBuilder_.Replace("{code}", Uri.EscapeDataString(ConvertToString(code, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Language>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// download security server's openapi definition
    /// </summary>
    /// <returns>openapi definition</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<FileResponse> DownloadOpenApiAsync()
    {
        return DownloadOpenApiAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// download security server's openapi definition
    /// </summary>
    /// <returns>openapi definition</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> DownloadOpenApiAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/openapi.yaml");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/x-yaml"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200 || status_ == 206)
                    {
                        var responseStream_ = response_.Content == null
                            ? Stream.Null
                            : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                        var fileResponse_ = new FileResponse(status_, headers_, responseStream_, null, response_);
                        disposeClient_ = false;
                        disposeResponse_ = false; // response and client are disposed by FileResponse
                        return fileResponse_;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get user data for the logged user
    /// </summary>
    /// <returns>user details</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<User> GetUserAsync()
    {
        return GetUserAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get user data for the logged user
    /// </summary>
    /// <returns>user details</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<User> GetUserAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/user");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<User>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get all security servers
    /// </summary>
    /// <param name="current_server">whether to only get the current server's identifier</param>
    /// <returns>list of SecurityServer objects</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<SecurityServer>> GetSecurityServersAsync(bool? current_server)
    {
        return GetSecurityServersAsync(current_server, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get all security servers
    /// </summary>
    /// <param name="current_server">whether to only get the current server's identifier</param>
    /// <returns>list of SecurityServer objects</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<SecurityServer>> GetSecurityServersAsync(bool? current_server,
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/security-servers?");
        if (current_server != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("current_server") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(current_server, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<SecurityServer>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get security server information
    /// </summary>
    /// <param name="id">id of the security server</param>
    /// <returns>ok</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<SecurityServer> GetSecurityServerAsync(string id)
    {
        return GetSecurityServerAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get security server information
    /// </summary>
    /// <param name="id">id of the security server</param>
    /// <returns>ok</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<SecurityServer> GetSecurityServerAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/security-servers/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<SecurityServer>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get service
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>ok</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Service> GetServiceAsync(string id)
    {
        return GetServiceAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get service
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>ok</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Service> GetServiceAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/services/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Service>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// update service
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>service modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Service> UpdateServiceAsync(string id, ServiceUpdate body)
    {
        return UpdateServiceAsync(id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// update service
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>service modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Service> UpdateServiceAsync(string id, ServiceUpdate body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/services/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PATCH");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Service>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// create endpoint
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>endpoint added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Endpoint> AddEndpointAsync(string id, Endpoint body)
    {
        return AddEndpointAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// create endpoint
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>endpoint added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Endpoint> AddEndpointAsync(string id, Endpoint body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException(nameof(id));

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/services/{id}/endpoints");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Endpoint>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("an existing item already exists", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get service clients who have access rights for the selected service
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>list of service clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<ServiceClient>> GetServiceServiceClientsAsync(string id)
    {
        return GetServiceServiceClientsAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get service clients who have access rights for the selected service
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>list of service clients</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<ServiceClient>> GetServiceServiceClientsAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/services/{id}/service-clients");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<ServiceClient>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// add access rights to selected service for new ServiceClients
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <param name="body"></param>
    /// <returns>access rights added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<ServiceClient>> AddServiceServiceClientsAsync(string id, ServiceClients body)
    {
        return AddServiceServiceClientsAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add access rights to selected service for new ServiceClients
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>access rights added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<ServiceClient>> AddServiceServiceClientsAsync(string id, ServiceClients body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException(nameof(id));

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/services/{id}/service-clients");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<ServiceClient>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("resource requested does not exists", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// remove access to selected service from given ServiceClients
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <param name="body"></param>
    /// <returns>access right(s) deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteServiceServiceClientsAsync(string id, ServiceClients body)
    {
        return DeleteServiceServiceClientsAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// remove access to selected service from given ServiceClients
    /// </summary>
    /// <param name="id">id of the service</param>
    /// <returns>access right(s) deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteServiceServiceClientsAsync(string id, ServiceClients body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException(nameof(id));

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/services/{id}/service-clients/delete");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("resource requested does not exists", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Get an endpoint by its id
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <returns>endpoint</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Endpoint> GetEndpointAsync(string id)
    {
        return GetEndpointAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get an endpoint by its id
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <returns>endpoint</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Endpoint> GetEndpointAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/endpoints/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Endpoint>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("resource requested does not exists", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Update an endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <param name="body"></param>
    /// <returns>endpoint updated</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Endpoint> UpdateEndpointAsync(string id, EndpointUpdate body)
    {
        return UpdateEndpointAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update an endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <returns>endpoint updated</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Endpoint> UpdateEndpointAsync(string id, EndpointUpdate body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/endpoints/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PATCH");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Endpoint>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("resource requested does not exists", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("an existing item already exists", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <returns>endpoint deleted</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteEndpointAsync(string id)
    {
        return DeleteEndpointAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <returns>endpoint deleted</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteEndpointAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/endpoints/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("resource requested does not exists", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get service clients who have access rights for the selected endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <returns>list of access rights</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<ServiceClient>> GetEndpointServiceClientsAsync(string id)
    {
        return GetEndpointServiceClientsAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get service clients who have access rights for the selected endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <returns>list of access rights</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<ServiceClient>> GetEndpointServiceClientsAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/endpoints/{id}/service-clients");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<ServiceClient>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("resource requested does not exists", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// add access rights for given service clients to the selected endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <param name="body"></param>
    /// <returns>access rights added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<ServiceClient>> AddEndpointServiceClientsAsync(string id, ServiceClients body)
    {
        return AddEndpointServiceClientsAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add access rights for given service clients to the selected endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <returns>access rights added</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<ServiceClient>> AddEndpointServiceClientsAsync(string id, ServiceClients body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/endpoints/{id}/service-clients");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<ServiceClient>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// remove access rights from specified service clients to the selected endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <param name="body">Service client to be removed</param>
    /// <returns>access right(s) deleted</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteEndpointServiceClientsAsync(string id, ServiceClients body)
    {
        return DeleteEndpointServiceClientsAsync(id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// remove access rights from specified service clients to the selected endpoint
    /// </summary>
    /// <param name="id">id of the endpoint</param>
    /// <param name="body">Service client to be removed</param>
    /// <returns>access right(s) deleted</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteEndpointServiceClientsAsync(string id, ServiceClients body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/endpoints/{id}/service-clients/delete");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get service description with provided id
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>wanted service description</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ServiceDescription> GetServiceDescriptionAsync(string id)
    {
        return GetServiceDescriptionAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get service description with provided id
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>wanted service description</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ServiceDescription> GetServiceDescriptionAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/service-descriptions/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ServiceDescription>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// update url or service code for the selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <param name="body"></param>
    /// <returns>service description modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ServiceDescription> UpdateServiceDescriptionAsync(string id, ServiceDescriptionUpdate body)
    {
        return UpdateServiceDescriptionAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// update url or service code for the selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>service description modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ServiceDescription> UpdateServiceDescriptionAsync(string id,
        ServiceDescriptionUpdate body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/service-descriptions/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PATCH");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ServiceDescription>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>(
                            "there are warnings or errors related to the service description", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>(
                            "<h3>An existing item already exists</h3> <p> If there are existing WSDL services with the same name, the error response will include the existing services\' names and the containing WSDL\'s URL in the metadata array. </p> <p> In this case the error code <code>service_already_exists</code> (WSDL) or <code>service_code_already_exists</code> (OPENAPI3) is used and the entries in the metadata array are ordered in following way <ul> <li>metadata has a list of strings [C1,U1,C2,U2....Cn,Un] where</li> <li>C1 = duplicate service full code</li> <li>U1 = URL of the existing WSDL that has the duplicate</li> </ul> </p> <strong>See the example</strong>",
                            status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>service description deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteServiceDescriptionAsync(string id)
    {
        return DeleteServiceDescriptionAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>service description deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteServiceDescriptionAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/service-descriptions/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("DELETE");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// disable selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <param name="body"></param>
    /// <returns>service description disabled</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DisableServiceDescriptionAsync(string id, ServiceDescriptionDisabledNotice body)
    {
        return DisableServiceDescriptionAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// disable selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>service description disabled</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DisableServiceDescriptionAsync(string id, ServiceDescriptionDisabledNotice body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/service-descriptions/{id}/disable");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// enable selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>service description enabled</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task EnableServiceDescriptionAsync(string id)
    {
        return EnableServiceDescriptionAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// enable selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>service description enabled</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task EnableServiceDescriptionAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/service-descriptions/{id}/enable");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// refresh selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <param name="body"></param>
    /// <returns>service description refreshed</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ServiceDescription> RefreshServiceDescriptionAsync(string id, IgnoreWarnings body)
    {
        return RefreshServiceDescriptionAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// refresh selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>service description refreshed</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ServiceDescription> RefreshServiceDescriptionAsync(string id, IgnoreWarnings body,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/service-descriptions/{id}/refresh");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PUT");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ServiceDescription>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>(
                            "there are warnings or errors related to the service description", status_,
                            objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>(
                            "<h3>An existing item already exists</h3> <p> If there are existing WSDL services with the same name, the error response will include the existing services\' names and the containing WSDL\'s URL in the metadata array. </p> <p> In this case the error code <code>service_already_exists</code> (WSDL) or <code>service_code_already_exists</code> (OPENAPI3) is used and the entries in the metadata array are ordered in following way <ul> <li>metadata has a list of strings [C1,U1,C2,U2....Cn,Un] where</li> <li>C1 = duplicate service full code</li> <li>U1 = URL of the existing WSDL that has the duplicate</li> </ul> </p> <strong>See the example</strong>",
                            status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get services for the selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>list of services</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<Service>> GetServiceDescriptionServicesAsync(string id)
    {
        return GetServiceDescriptionServicesAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get services for the selected service description
    /// </summary>
    /// <param name="id">id of the service description</param>
    /// <returns>list of services</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<Service>> GetServiceDescriptionServicesAsync(string id,
        CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/service-descriptions/{id}/services");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<Service>>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// view the configuration anchor information
    /// </summary>
    /// <returns>anchor information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Anchor> GetAnchorAsync()
    {
        return GetAnchorAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// view the configuration anchor information
    /// </summary>
    /// <returns>anchor information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Anchor> GetAnchorAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/anchor");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Anchor>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Upload a new configuration anchor file when initializing a new security server.
    /// </summary>
    /// <param name="body">configuration anchor</param>
    /// <returns>configuration anchor uploaded</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task UploadInitialAnchorAsync(Stream body)
    {
        return UploadInitialAnchorAsync(body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Upload a new configuration anchor file when initializing a new security server.
    /// </summary>
    /// <param name="body">configuration anchor</param>
    /// <returns>configuration anchor uploaded</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task UploadInitialAnchorAsync(Stream body, CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/anchor");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StreamContent(body);
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Upload a configuration anchor file to replace an existing one.
    /// </summary>
    /// <param name="body">configuration anchor</param>
    /// <returns>configuration anchor uploaded</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task ReplaceAnchorAsync(Stream body)
    {
        return ReplaceAnchorAsync(body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Upload a configuration anchor file to replace an existing one.
    /// </summary>
    /// <param name="body">configuration anchor</param>
    /// <returns>configuration anchor uploaded</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task ReplaceAnchorAsync(Stream body, CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/anchor");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StreamContent(body);
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
                request_.Content = content_;
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// Read and the configuration anchor file and return the hash for a preview.
    /// </summary>
    /// <param name="validate_instance">Whether or not to validate the owner instance of the anchor. Set this to false explicitly when previewing an anchor in the security server initialization phase. Default value is true if the parameter is omitted.</param>
    /// <param name="body">configuration anchor</param>
    /// <returns>configuration anchor uploaded</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Anchor> PreviewAnchorAsync(bool? validate_instance, Stream body)
    {
        return PreviewAnchorAsync(validate_instance, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Read and the configuration anchor file and return the hash for a preview.
    /// </summary>
    /// <param name="validate_instance">Whether or not to validate the owner instance of the anchor. Set this to false explicitly when previewing an anchor in the security server initialization phase. Default value is true if the parameter is omitted.</param>
    /// <param name="body">configuration anchor</param>
    /// <returns>configuration anchor uploaded</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Anchor> PreviewAnchorAsync(bool? validate_instance, Stream body,
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/anchor/previews?");
        if (validate_instance != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("validate_instance") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(validate_instance, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StreamContent(body);
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Anchor>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// download configuration anchor information
    /// </summary>
    /// <returns>configuration anchor</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<FileResponse> DownloadAnchorAsync()
    {
        return DownloadAnchorAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// download configuration anchor information
    /// </summary>
    /// <returns>configuration anchor</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> DownloadAnchorAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/anchor/download");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/xml"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200 || status_ == 206)
                    {
                        var responseStream_ = response_.Content == null
                            ? Stream.Null
                            : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                        var fileResponse_ = new FileResponse(status_, headers_, responseStream_, null, response_);
                        disposeClient_ = false;
                        disposeResponse_ = false; // response and client are disposed by FileResponse
                        return fileResponse_;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// view the security server certificate information
    /// </summary>
    /// <returns>certificate information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<CertificateDetails> GetSystemCertificateAsync()
    {
        return GetSystemCertificateAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// view the security server certificate information
    /// </summary>
    /// <returns>certificate information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<CertificateDetails> GetSystemCertificateAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/certificate");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<CertificateDetails>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// generate a new internal TLS key and cert
    /// </summary>
    /// <returns>tls key generated</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task GenerateSystemTlsKeyAndCertificateAsync()
    {
        return GenerateSystemTlsKeyAndCertificateAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// generate a new internal TLS key and cert
    /// </summary>
    /// <returns>tls key generated</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task GenerateSystemTlsKeyAndCertificateAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/certificate");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("POST");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// download the security server certificate as gzip compressed tar archive
    /// </summary>
    /// <returns>information fetched successfully</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<FileResponse> DownloadSystemCertificateAsync()
    {
        return DownloadSystemCertificateAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// download the security server certificate as gzip compressed tar archive
    /// </summary>
    /// <returns>information fetched successfully</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> DownloadSystemCertificateAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/certificate/export");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/gzip"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200 || status_ == 206)
                    {
                        var responseStream_ = response_.Content == null
                            ? Stream.Null
                            : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                        var fileResponse_ = new FileResponse(status_, headers_, responseStream_, null, response_);
                        disposeClient_ = false;
                        disposeResponse_ = false; // response and client are disposed by FileResponse
                        return fileResponse_;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// generate new certificate request
    /// </summary>
    /// <returns>created CSR</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<FileResponse> GenerateSystemCertificateRequestAsync(DistinguishedName body)
    {
        return GenerateSystemCertificateRequestAsync(body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// generate new certificate request
    /// </summary>
    /// <returns>created CSR</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<FileResponse> GenerateSystemCertificateRequestAsync(DistinguishedName body,
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/certificate/csr");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var responseStream_ = response_.Content == null
                            ? Stream.Null
                            : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                        var fileResponse_ = new FileResponse(status_, headers_, responseStream_, null, response_);
                        disposeClient_ = false;
                        disposeResponse_ = false; // response and client are disposed by FileResponse
                        return fileResponse_;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// import new internal TLS certificate.
    /// </summary>
    /// <param name="body">certificate to add</param>
    /// <returns>tls certificate imported</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<CertificateDetails> ImportSystemCertificateAsync(Stream body)
    {
        return ImportSystemCertificateAsync(body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// import new internal TLS certificate.
    /// </summary>
    /// <param name="body">certificate to add</param>
    /// <returns>tls certificate imported</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<CertificateDetails> ImportSystemCertificateAsync(Stream body,
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/certificate/import");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StreamContent(body);
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<CertificateDetails>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// view the approved certificate authorities
    /// </summary>
    /// <param name="key_usage_type">return only CAs suitable for this type of key usage</param>
    /// <param name="include_intermediate_cas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is "false".</param>
    /// <returns>list of approved certificate authorities</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<CertificateAuthority>> GetApprovedCertificateAuthoritiesAsync(
        KeyUsageType? key_usage_type, bool? include_intermediate_cas)
    {
        return GetApprovedCertificateAuthoritiesAsync(key_usage_type, include_intermediate_cas, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// view the approved certificate authorities
    /// </summary>
    /// <param name="key_usage_type">return only CAs suitable for this type of key usage</param>
    /// <param name="include_intermediate_cas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is "false".</param>
    /// <returns>list of approved certificate authorities</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<CertificateAuthority>> GetApprovedCertificateAuthoritiesAsync(
        KeyUsageType? key_usage_type, bool? include_intermediate_cas, CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/certificate-authorities?");
        if (key_usage_type != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("key_usage_type") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(key_usage_type, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        if (include_intermediate_cas != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("include_intermediate_cas") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(include_intermediate_cas, CultureInfo.InvariantCulture)))
                .Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<CertificateAuthority>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get description of subject DN fields for CSR
    /// </summary>
    /// <param name="ca_name">common name of the CA</param>
    /// <param name="key_id">id of the key. If provided, used only for validating correct key usage</param>
    /// <param name="key_usage_type">which usage type this CSR is for</param>
    /// <param name="member_id">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;</param>
    /// <param name="is_new_member">whether or not the member in the member_id parameter is a new member</param>
    /// <returns>csr subject field objects</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<CsrSubjectFieldDescription>> GetSubjectFieldDescriptionsAsync(string ca_name,
        string key_id, KeyUsageType key_usage_type, string member_id, bool? is_new_member)
    {
        return GetSubjectFieldDescriptionsAsync(ca_name, key_id, key_usage_type, member_id, is_new_member,
            CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get description of subject DN fields for CSR
    /// </summary>
    /// <param name="ca_name">common name of the CA</param>
    /// <param name="key_id">id of the key. If provided, used only for validating correct key usage</param>
    /// <param name="key_usage_type">which usage type this CSR is for</param>
    /// <param name="member_id">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt;</param>
    /// <param name="is_new_member">whether or not the member in the member_id parameter is a new member</param>
    /// <returns>csr subject field objects</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<CsrSubjectFieldDescription>> GetSubjectFieldDescriptionsAsync(string ca_name,
        string key_id, KeyUsageType key_usage_type, string member_id, bool? is_new_member,
        CancellationToken cancellationToken)
    {
        if (ca_name == null)
            throw new ArgumentNullException("ca_name");

        if (key_usage_type == null)
            throw new ArgumentNullException("key_usage_type");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "")
            .Append("/certificate-authorities/{ca_name}/csr-subject-fields?");
        urlBuilder_.Replace("{ca_name}", Uri.EscapeDataString(ConvertToString(ca_name, CultureInfo.InvariantCulture)));
        if (key_id != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("key_id") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(key_id, CultureInfo.InvariantCulture))).Append("&");
        }

        urlBuilder_.Append(Uri.EscapeDataString("key_usage_type") + "=")
            .Append(Uri.EscapeDataString(ConvertToString(key_usage_type, CultureInfo.InvariantCulture))).Append("&");
        if (member_id != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("member_id") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(member_id, CultureInfo.InvariantCulture))).Append("&");
        }

        if (is_new_member != null)
        {
            urlBuilder_.Append(Uri.EscapeDataString("is_new_member") + "=")
                .Append(Uri.EscapeDataString(ConvertToString(is_new_member, CultureInfo.InvariantCulture))).Append("&");
        }

        urlBuilder_.Length--;

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<CsrSubjectFieldDescription>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// view the configured timestamping services
    /// </summary>
    /// <returns>list of configured timestamping services</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<TimestampingService>> GetConfiguredTimestampingServicesAsync()
    {
        return GetConfiguredTimestampingServicesAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// view the configured timestamping services
    /// </summary>
    /// <returns>list of configured timestamping services</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<TimestampingService>> GetConfiguredTimestampingServicesAsync(
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/timestamping-services");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<TimestampingService>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// add a configured timestamping service
    /// </summary>
    /// <param name="body">Timestamping service to add</param>
    /// <returns>timestamping service created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<TimestampingService> AddConfiguredTimestampingServiceAsync(TimestampingService body)
    {
        return AddConfiguredTimestampingServiceAsync(body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add a configured timestamping service
    /// </summary>
    /// <param name="body">Timestamping service to add</param>
    /// <returns>timestamping service created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<TimestampingService> AddConfiguredTimestampingServiceAsync(TimestampingService body,
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/timestamping-services");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<TimestampingService>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// delete configured timestamping service
    /// </summary>
    /// <param name="body">Timestamping service to delete</param>
    /// <returns>timestamping service deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task DeleteConfiguredTimestampingServiceAsync(TimestampingService body)
    {
        return DeleteConfiguredTimestampingServiceAsync(body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// delete configured timestamping service
    /// </summary>
    /// <param name="body">Timestamping service to delete</param>
    /// <returns>timestamping service deletion was successful</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task DeleteConfiguredTimestampingServiceAsync(TimestampingService body,
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/timestamping-services/delete");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get the node type
    /// </summary>
    /// <returns>node type information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<NodeTypeResponse> GetNodeTypeAsync()
    {
        return GetNodeTypeAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get the node type
    /// </summary>
    /// <returns>node type information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<NodeTypeResponse> GetNodeTypeAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/node-type");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<NodeTypeResponse>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get information for the system version
    /// </summary>
    /// <returns>system version information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<VersionInfo> SystemVersionAsync()
    {
        return SystemVersionAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get information for the system version
    /// </summary>
    /// <returns>system version information</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<VersionInfo> SystemVersionAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/system/version");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<VersionInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// view the approved timestamping services
    /// </summary>
    /// <returns>list of approved timestamping services</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<TimestampingService>> GetApprovedTimestampingServicesAsync()
    {
        return GetApprovedTimestampingServicesAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// view the approved timestamping services
    /// </summary>
    /// <returns>list of approved timestamping services</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<TimestampingService>> GetApprovedTimestampingServicesAsync(
        CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/timestamping-services");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<TimestampingService>>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get security server tokens
    /// </summary>
    /// <returns>list of tokens</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<Token>> GetTokensAsync()
    {
        return GetTokensAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get security server tokens
    /// </summary>
    /// <returns>list of tokens</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<Token>> GetTokensAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tokens");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<Token>>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get security server token information
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <returns>token object</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Token> GetTokenAsync(string id)
    {
        return GetTokenAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get security server token information
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <returns>token object</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Token> GetTokenAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tokens/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Token>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// update security server token information
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <param name="body"></param>
    /// <returns>token modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Token> UpdateTokenAsync(string id, TokenName body)
    {
        return UpdateTokenAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// update security server token information
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <returns>token modified</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Token> UpdateTokenAsync(string id, TokenName body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tokens/{id}");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PATCH");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Token>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// update security server software token pin code
    /// </summary>
    /// <param name="id">id of the software token</param>
    /// <param name="body"></param>
    /// <returns>software token pin updated</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task UpdateTokenPinAsync(string id, TokenPinUpdate body)
    {
        return UpdateTokenPinAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// update security server software token pin code
    /// </summary>
    /// <param name="id">id of the software token</param>
    /// <returns>software token pin updated</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task UpdateTokenPinAsync(string id, TokenPinUpdate body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tokens/{id}/pin");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PUT");

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 204)
                    {
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// add a new key and generate a csr for it
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <param name="body"></param>
    /// <returns>key created for the token</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<KeyWithCertificateSigningRequestId> AddKeyAndCsrAsync(string id, KeyLabelWithCsrGenerate body)
    {
        return AddKeyAndCsrAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add a new key and generate a csr for it
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <returns>key created for the token</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<KeyWithCertificateSigningRequestId> AddKeyAndCsrAsync(string id,
        KeyLabelWithCsrGenerate body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tokens/{id}/keys-with-csrs");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<KeyWithCertificateSigningRequestId>(response_, headers_,
                                cancellationToken).ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ErrorInfo>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        throw new XRoadApiException<ErrorInfo>("request was invalid", status_, objectResponse_.Text,
                            headers_, objectResponse_.Object, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists or token not logged in", status_,
                            responseText_, headers_, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// add new key
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <param name="body"></param>
    /// <returns>key created for the token</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Key> AddKeyAsync(string id, KeyLabel body)
    {
        return AddKeyAsync(id, body, CancellationToken.None);
    }

    /// <param name="body"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// add new key
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <returns>key created for the token</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Key> AddKeyAsync(string id, KeyLabel body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tokens/{id}/keys");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("POST");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 201)
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<Key>(response_, headers_, cancellationToken)
                            .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 409)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("an existing item already exists or token not logged in", status_,
                            responseText_, headers_, null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// login to token
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <param name="body"></param>
    /// <returns>logged in</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Token> LoginTokenAsync(string id, TokenPassword body)
    {
        return LoginTokenAsync(id, body, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// login to token
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <returns>logged in</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Token> LoginTokenAsync(string id, TokenPassword body, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tokens/{id}/login");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request_.Content = content_;
                request_.Method = new HttpMethod("PUT");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Token>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// logout from token
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <returns>logged out</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<Token> LogoutTokenAsync(string id)
    {
        return LogoutTokenAsync(id, CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// logout from token
    /// </summary>
    /// <param name="id">id of the token</param>
    /// <returns>logged out</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<Token> LogoutTokenAsync(string id, CancellationToken cancellationToken)
    {
        if (id == null)
            throw new ArgumentNullException("id");

        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/tokens/{id}/logout");
        urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                request_.Method = new HttpMethod("PUT");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<Token>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// get list of known xroad instance identifiers
    /// </summary>
    /// <returns>xroad instance identifiers</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual Task<ICollection<string>> GetXroadInstancesAsync()
    {
        return GetXroadInstancesAsync(CancellationToken.None);
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// get list of known xroad instance identifiers
    /// </summary>
    /// <returns>xroad instance identifiers</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<ICollection<string>> GetXroadInstancesAsync(CancellationToken cancellationToken)
    {
        var urlBuilder_ = new StringBuilder();
        urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/xroad-instances");

        var client_ = _httpClient;
        var disposeClient_ = false;
        try
        {
            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                PrepareRequest(client_, request_, urlBuilder_);

                var url_ = urlBuilder_.ToString();
                request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                PrepareRequest(client_, request_, url_);

                var response_ = await client_
                    .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                    .ConfigureAwait(false);
                var disposeResponse_ = true;
                try
                {
                    var headers_ = response_.Headers.ToDictionary(h_ => h_.Key, h_ => h_.Value);
                    if (response_.Content != null && response_.Content.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = (int)response_.StatusCode;
                    if (status_ == 200)
                    {
                        var objectResponse_ =
                            await ReadObjectResponseAsync<ICollection<string>>(response_, headers_, cancellationToken)
                                .ConfigureAwait(false);
                        if (objectResponse_.Object == null)
                        {
                            throw new ApiException("Response was null which was not expected.", status_,
                                objectResponse_.Text, headers_, null);
                        }

                        return objectResponse_.Object;
                    }
                    else if (status_ == 400)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request was invalid", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 401)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("authentication credentials are missing", status_, responseText_,
                            headers_, null);
                    }
                    else if (status_ == 403)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request has been refused", status_, responseText_, headers_, null);
                    }
                    else if (status_ == 404)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("resource requested does not exists", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 406)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("request specified an invalid format", status_, responseText_, headers_,
                            null);
                    }
                    else if (status_ == 500)
                    {
                        string responseText_ = (response_.Content == null)
                            ? string.Empty
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("internal server error", status_, responseText_, headers_, null);
                    }
                    else
                    {
                        var responseData_ = response_.Content == null
                            ? null
                            : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException(
                            "The HTTP status code of the response was not expected (" + status_ + ").", status_,
                            responseData_, headers_, null);
                    }
                }
                finally
                {
                    if (disposeResponse_)
                        response_.Dispose();
                }
            }
        }
        finally
        {
            if (disposeClient_)
                client_.Dispose();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    protected struct ObjectResponseResult<T>
    {
        // <inherit-doc>
        /// <param name="responseObject"></param>
        /// <param name="responseText"></param>
        public ObjectResponseResult(T responseObject, string responseText)
        {
            Object = responseObject;
            Text = responseText;
        }

        /// <summary>
        /// 
        /// </summary>
        public T Object { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Text { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReadResponseAsString { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <param name="headers"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="ApiException"></exception>
    protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response,
        IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
    {
        if (response?.Content == null)
        {
            return new ObjectResponseResult<T>(default, string.Empty);
        }

        if (ReadResponseAsString)
        {
            var responseText = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                var typedBody = JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                return new ObjectResponseResult<T>(typedBody, responseText);
            }
            catch (JsonException exception)
            {
                var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
            }
        }

        try
        {
            await using var responseStream =
                await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            using var streamReader = new StreamReader(responseStream);
            using var jsonTextReader = new JsonTextReader(streamReader);
            var serializer = JsonSerializer.Create(JsonSerializerSettings);
            var typedBody = serializer.Deserialize<T>(jsonTextReader);
            return new ObjectResponseResult<T>(typedBody, string.Empty);
        }
        catch (JsonException exception)
        {
            var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
            throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
        }
    }

    private string ConvertToString(object value, CultureInfo cultureInfo)
    {
        if (value == null)
        {
            return "";
        }

        if (value is Enum)
        {
            var name = Enum.GetName(value.GetType(), value);
            if (name != null)
            {
                var field = value.GetType().GetTypeInfo().GetDeclaredField(name);
                if (field != null)
                {
                    if (field.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute attribute)
                    {
                        return attribute.Value ?? name;
                    }
                }

                var converted =
                    Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                return converted ?? string.Empty;
            }
        }
        else if (value is bool b)
        {
            return Convert.ToString(b, cultureInfo).ToLowerInvariant();
        }
        else if (value is byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
        else if (value.GetType().IsArray)
        {
            var array = ((Array)value).OfType<object>();
            return string.Join(",", array.Select(o => ConvertToString(o, cultureInfo)));
        }

        var result = Convert.ToString(value, cultureInfo);
        return result ?? "";
    }
}