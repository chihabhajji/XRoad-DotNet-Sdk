/*
 * X-Road Security Server Admin API
 *
 * X-Road Security Server Admin API. Note that the error metadata responses described in some endpoints are subjects to change and may be updated in upcoming versions.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: info@niis.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XRoad.Sdk.Client;
using XRoad.Sdk.Model;

namespace XRoad.Sdk.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICertificateAuthoritiesApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// view the approved certificate authorities
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;Administrator views the approved certificate authorities.&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyUsageType">return only CAs suitable for this type of key usage (optional)</param>
    /// <param name="includeIntermediateCas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \&quot;false\&quot;. (optional, default to false)</param>
    /// <returns>List&lt;CertificateAuthority&gt;</returns>
    List<CertificateAuthority> GetApprovedCertificateAuthorities(KeyUsageType? keyUsageType = default,
        bool? includeIntermediateCas = default);

    /// <summary>
    /// view the approved certificate authorities
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;Administrator views the approved certificate authorities.&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyUsageType">return only CAs suitable for this type of key usage (optional)</param>
    /// <param name="includeIntermediateCas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \&quot;false\&quot;. (optional, default to false)</param>
    /// <returns>ApiResponse of List&lt;CertificateAuthority&gt;</returns>
    ApiResponse<List<CertificateAuthority>> GetApprovedCertificateAuthoritiesWithHttpInfo(
        KeyUsageType? keyUsageType = default, bool? includeIntermediateCas = default);

    /// <summary>
    /// get description of subject DN fields for CSR
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;List DN field descriptions to collect CSR parameters&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="caName">common name of the CA</param>
    /// <param name="keyUsageType">which usage type this CSR is for</param>
    /// <param name="keyId">id of the key. If provided, used only for validating correct key usage (optional)</param>
    /// <param name="memberId">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; (optional)</param>
    /// <param name="isNewMember">whether or not the member in the member_id parameter is a new member (optional, default to false)</param>
    /// <returns>List&lt;CsrSubjectFieldDescription&gt;</returns>
    List<CsrSubjectFieldDescription> GetSubjectFieldDescriptions(string caName, KeyUsageType keyUsageType,
        string keyId = default, string memberId = default, bool? isNewMember = default);

    /// <summary>
    /// get description of subject DN fields for CSR
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;List DN field descriptions to collect CSR parameters&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="caName">common name of the CA</param>
    /// <param name="keyUsageType">which usage type this CSR is for</param>
    /// <param name="keyId">id of the key. If provided, used only for validating correct key usage (optional)</param>
    /// <param name="memberId">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; (optional)</param>
    /// <param name="isNewMember">whether or not the member in the member_id parameter is a new member (optional, default to false)</param>
    /// <returns>ApiResponse of List&lt;CsrSubjectFieldDescription&gt;</returns>
    ApiResponse<List<CsrSubjectFieldDescription>> GetSubjectFieldDescriptionsWithHttpInfo(string caName,
        KeyUsageType keyUsageType, string keyId = default, string memberId = default, bool? isNewMember = default);

    #endregion Synchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICertificateAuthoritiesApiAsync : IApiAccessor
{
    #region Asynchronous Operations

    /// <summary>
    /// view the approved certificate authorities
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;Administrator views the approved certificate authorities.&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyUsageType">return only CAs suitable for this type of key usage (optional)</param>
    /// <param name="includeIntermediateCas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \&quot;false\&quot;. (optional, default to false)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;CertificateAuthority&gt;</returns>
    Task<List<CertificateAuthority>> GetApprovedCertificateAuthoritiesAsync(KeyUsageType? keyUsageType = default,
        bool? includeIntermediateCas = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// view the approved certificate authorities
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;Administrator views the approved certificate authorities.&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyUsageType">return only CAs suitable for this type of key usage (optional)</param>
    /// <param name="includeIntermediateCas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \&quot;false\&quot;. (optional, default to false)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;CertificateAuthority&gt;)</returns>
    Task<ApiResponse<List<CertificateAuthority>>> GetApprovedCertificateAuthoritiesWithHttpInfoAsync(
        KeyUsageType? keyUsageType = default, bool? includeIntermediateCas = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// get description of subject DN fields for CSR
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;List DN field descriptions to collect CSR parameters&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="caName">common name of the CA</param>
    /// <param name="keyUsageType">which usage type this CSR is for</param>
    /// <param name="keyId">id of the key. If provided, used only for validating correct key usage (optional)</param>
    /// <param name="memberId">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; (optional)</param>
    /// <param name="isNewMember">whether or not the member in the member_id parameter is a new member (optional, default to false)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;CsrSubjectFieldDescription&gt;</returns>
    Task<List<CsrSubjectFieldDescription>> GetSubjectFieldDescriptionsAsync(string caName, KeyUsageType keyUsageType,
        string keyId = default, string memberId = default, bool? isNewMember = default,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// get description of subject DN fields for CSR
    /// </summary>
    /// <remarks>
    /// &lt;h3&gt;List DN field descriptions to collect CSR parameters&lt;/h3&gt;
    /// </remarks>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="caName">common name of the CA</param>
    /// <param name="keyUsageType">which usage type this CSR is for</param>
    /// <param name="keyId">id of the key. If provided, used only for validating correct key usage (optional)</param>
    /// <param name="memberId">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; (optional)</param>
    /// <param name="isNewMember">whether or not the member in the member_id parameter is a new member (optional, default to false)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;CsrSubjectFieldDescription&gt;)</returns>
    Task<ApiResponse<List<CsrSubjectFieldDescription>>> GetSubjectFieldDescriptionsWithHttpInfoAsync(string caName,
        KeyUsageType keyUsageType, string keyId = default, string memberId = default, bool? isNewMember = default,
        CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICertificateAuthoritiesApi : ICertificateAuthoritiesApiSync, ICertificateAuthoritiesApiAsync
{
}

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public class CertificateAuthoritiesApi : ICertificateAuthoritiesApi
{
    private ExceptionFactory _exceptionFactory = (_, _) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="CertificateAuthoritiesApi"/> class.
    /// </summary>
    /// <returns></returns>
    public CertificateAuthoritiesApi() : this((string) null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CertificateAuthoritiesApi"/> class.
    /// </summary>
    /// <returns></returns>
    public CertificateAuthoritiesApi(string basePath)
    {
        Configuration = Sdk.Client.Configuration.MergeConfigurations(
            GlobalConfiguration.Instance,
            new Configuration {BasePath = basePath}
        );
        Client = new ApiClient(Configuration.BasePath);
        AsynchronousClient = new ApiClient(Configuration.BasePath);
        ExceptionFactory = Sdk.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CertificateAuthoritiesApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public CertificateAuthoritiesApi(Configuration configuration)
    {
        if (configuration == null) throw new ArgumentNullException("configuration");

        Configuration = Sdk.Client.Configuration.MergeConfigurations(
            GlobalConfiguration.Instance,
            configuration
        );
        Client = new ApiClient(Configuration.BasePath);
        AsynchronousClient = new ApiClient(Configuration.BasePath);
        ExceptionFactory = Sdk.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CertificateAuthoritiesApi"/> class
    /// using a Configuration object and client instance.
    /// </summary>
    /// <param name="client">The client interface for synchronous API access.</param>
    /// <param name="asyncClient">The client interface for asynchronous API access.</param>
    /// <param name="configuration">The configuration object.</param>
    public CertificateAuthoritiesApi(ISynchronousClient client, IAsynchronousClient asyncClient,
        IReadableConfiguration configuration)
    {
        if (client == null) throw new ArgumentNullException("client");
        if (asyncClient == null) throw new ArgumentNullException("asyncClient");
        if (configuration == null) throw new ArgumentNullException("configuration");

        Client = client;
        AsynchronousClient = asyncClient;
        Configuration = configuration;
        ExceptionFactory = Sdk.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// The client for accessing this underlying API asynchronously.
    /// </summary>
    public IAsynchronousClient AsynchronousClient { get; set; }

    /// <summary>
    /// The client for accessing this underlying API synchronously.
    /// </summary>
    public ISynchronousClient Client { get; set; }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return Configuration.BasePath;
    }

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public IReadableConfiguration Configuration { get; set; }

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public ExceptionFactory ExceptionFactory
    {
        get
        {
            if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
            return _exceptionFactory;
        }
        set => _exceptionFactory = value;
    }

    /// <summary>
    /// view the approved certificate authorities &lt;h3&gt;Administrator views the approved certificate authorities.&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyUsageType">return only CAs suitable for this type of key usage (optional)</param>
    /// <param name="includeIntermediateCas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \&quot;false\&quot;. (optional, default to false)</param>
    /// <returns>List&lt;CertificateAuthority&gt;</returns>
    public List<CertificateAuthority> GetApprovedCertificateAuthorities(KeyUsageType? keyUsageType = default,
        bool? includeIntermediateCas = default)
    {
        var localVarResponse = GetApprovedCertificateAuthoritiesWithHttpInfo(keyUsageType, includeIntermediateCas);
        return localVarResponse.Data;
    }

    /// <summary>
    /// view the approved certificate authorities &lt;h3&gt;Administrator views the approved certificate authorities.&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyUsageType">return only CAs suitable for this type of key usage (optional)</param>
    /// <param name="includeIntermediateCas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \&quot;false\&quot;. (optional, default to false)</param>
    /// <returns>ApiResponse of List&lt;CertificateAuthority&gt;</returns>
    public ApiResponse<List<CertificateAuthority>> GetApprovedCertificateAuthoritiesWithHttpInfo(
        KeyUsageType? keyUsageType = default, bool? includeIntermediateCas = default)
    {
        var localVarRequestOptions = new RequestOptions();

        var contentTypes = Array.Empty<string>();

        // to determine the Accept header
        string[] accepts =
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        if (keyUsageType != null)
            localVarRequestOptions.QueryParameters.Add(
                ClientUtils.ParameterToMultiMap("", "key_usage_type", keyUsageType));
        if (includeIntermediateCas != null)
            localVarRequestOptions.QueryParameters.Add(
                ClientUtils.ParameterToMultiMap("", "include_intermediate_cas", includeIntermediateCas));

        // authentication (ApiKeyAuth) required
        if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            localVarRequestOptions.HeaderParameters.Add("Authorization",
                Configuration.GetApiKeyWithPrefix("Authorization"));

        // make the HTTP request
        var localVarResponse =
            Client.Get<List<CertificateAuthority>>("/certificate-authorities", localVarRequestOptions, Configuration);
        if (ExceptionFactory?.Invoke("GetApprovedCertificateAuthorities", localVarResponse) is { } exception)
            throw exception;

        return localVarResponse;
    }

    /// <summary>
    /// view the approved certificate authorities &lt;h3&gt;Administrator views the approved certificate authorities.&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyUsageType">return only CAs suitable for this type of key usage (optional)</param>
    /// <param name="includeIntermediateCas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \&quot;false\&quot;. (optional, default to false)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;CertificateAuthority&gt;</returns>
    public async Task<List<CertificateAuthority>> GetApprovedCertificateAuthoritiesAsync(
        KeyUsageType? keyUsageType = default, bool? includeIntermediateCas = default,
        CancellationToken cancellationToken = default)
    {
        var localVarResponse =
            await GetApprovedCertificateAuthoritiesWithHttpInfoAsync(keyUsageType, includeIntermediateCas,
                cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// view the approved certificate authorities &lt;h3&gt;Administrator views the approved certificate authorities.&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="keyUsageType">return only CAs suitable for this type of key usage (optional)</param>
    /// <param name="includeIntermediateCas">if true, include also intermediate CAs. Otherwise only top CAs are included. Default value is \&quot;false\&quot;. (optional, default to false)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;CertificateAuthority&gt;)</returns>
    public async Task<ApiResponse<List<CertificateAuthority>>> GetApprovedCertificateAuthoritiesWithHttpInfoAsync(
        KeyUsageType? keyUsageType = default, bool? includeIntermediateCas = default,
        CancellationToken cancellationToken = default)
    {
        var localVarRequestOptions = new RequestOptions();

        var contentTypes = Array.Empty<string>();

        // to determine the Accept header
        string[] accepts =
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        if (keyUsageType != null)
            localVarRequestOptions.QueryParameters.Add(
                ClientUtils.ParameterToMultiMap("", "key_usage_type", keyUsageType));
        if (includeIntermediateCas != null)
            localVarRequestOptions.QueryParameters.Add(
                ClientUtils.ParameterToMultiMap("", "include_intermediate_cas", includeIntermediateCas));

        // authentication (ApiKeyAuth) required
        if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            localVarRequestOptions.HeaderParameters.Add("Authorization",
                Configuration.GetApiKeyWithPrefix("Authorization"));

        // make the HTTP request
        var localVarResponse = await AsynchronousClient
            .GetAsync<List<CertificateAuthority>>("/certificate-authorities", localVarRequestOptions, Configuration,
                cancellationToken).ConfigureAwait(false);

        if (ExceptionFactory?.Invoke("GetApprovedCertificateAuthorities", localVarResponse) is { } exception)
            throw exception;

        return localVarResponse;
    }

    /// <summary>
    /// get description of subject DN fields for CSR &lt;h3&gt;List DN field descriptions to collect CSR parameters&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="caName">common name of the CA</param>
    /// <param name="keyUsageType">which usage type this CSR is for</param>
    /// <param name="keyId">id of the key. If provided, used only for validating correct key usage (optional)</param>
    /// <param name="memberId">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; (optional)</param>
    /// <param name="isNewMember">whether or not the member in the member_id parameter is a new member (optional, default to false)</param>
    /// <returns>List&lt;CsrSubjectFieldDescription&gt;</returns>
    public List<CsrSubjectFieldDescription> GetSubjectFieldDescriptions(string caName, KeyUsageType keyUsageType,
        string keyId = default, string memberId = default, bool? isNewMember = default)
    {
        var localVarResponse =
            GetSubjectFieldDescriptionsWithHttpInfo(caName, keyUsageType, keyId, memberId, isNewMember);
        return localVarResponse.Data;
    }

    /// <summary>
    /// get description of subject DN fields for CSR &lt;h3&gt;List DN field descriptions to collect CSR parameters&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="caName">common name of the CA</param>
    /// <param name="keyUsageType">which usage type this CSR is for</param>
    /// <param name="keyId">id of the key. If provided, used only for validating correct key usage (optional)</param>
    /// <param name="memberId">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; (optional)</param>
    /// <param name="isNewMember">whether or not the member in the member_id parameter is a new member (optional, default to false)</param>
    /// <returns>ApiResponse of List&lt;CsrSubjectFieldDescription&gt;</returns>
    public ApiResponse<List<CsrSubjectFieldDescription>> GetSubjectFieldDescriptionsWithHttpInfo(string caName,
        KeyUsageType keyUsageType, string keyId = default, string memberId = default, bool? isNewMember = default)
    {
        // verify the required parameter 'caName' is set
        if (caName == null)
            throw new ApiException(400,
                "Missing required parameter 'caName' when calling CertificateAuthoritiesApi->GetSubjectFieldDescriptions");

        var localVarRequestOptions = new RequestOptions();

        var contentTypes = Array.Empty<string>();

        // to determine the Accept header
        string[] accepts =
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        localVarRequestOptions.PathParameters.Add("ca_name", ClientUtils.ParameterToString(caName)); // path parameter
        if (keyId != null)
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "key_id", keyId));
        localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "key_usage_type", keyUsageType));
        if (memberId != null)
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "member_id", memberId));
        if (isNewMember != null)
            localVarRequestOptions.QueryParameters.Add(
                ClientUtils.ParameterToMultiMap("", "is_new_member", isNewMember));

        // authentication (ApiKeyAuth) required
        if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            localVarRequestOptions.HeaderParameters.Add("Authorization",
                Configuration.GetApiKeyWithPrefix("Authorization"));

        // make the HTTP request
        var localVarResponse = Client.Get<List<CsrSubjectFieldDescription>>(
            "/certificate-authorities/{ca_name}/csr-subject-fields", localVarRequestOptions, Configuration);
        if (ExceptionFactory?.Invoke("GetSubjectFieldDescriptions", localVarResponse) is { } exception)
            throw exception;

        return localVarResponse;
    }

    /// <summary>
    /// get description of subject DN fields for CSR &lt;h3&gt;List DN field descriptions to collect CSR parameters&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="caName">common name of the CA</param>
    /// <param name="keyUsageType">which usage type this CSR is for</param>
    /// <param name="keyId">id of the key. If provided, used only for validating correct key usage (optional)</param>
    /// <param name="memberId">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; (optional)</param>
    /// <param name="isNewMember">whether or not the member in the member_id parameter is a new member (optional, default to false)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of List&lt;CsrSubjectFieldDescription&gt;</returns>
    public async Task<List<CsrSubjectFieldDescription>> GetSubjectFieldDescriptionsAsync(string caName,
        KeyUsageType keyUsageType, string keyId = default, string memberId = default, bool? isNewMember = default,
        CancellationToken cancellationToken = default)
    {
        var localVarResponse =
            await GetSubjectFieldDescriptionsWithHttpInfoAsync(caName, keyUsageType, keyId, memberId, isNewMember,
                cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// get description of subject DN fields for CSR &lt;h3&gt;List DN field descriptions to collect CSR parameters&lt;/h3&gt;
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <param name="caName">common name of the CA</param>
    /// <param name="keyUsageType">which usage type this CSR is for</param>
    /// <param name="keyId">id of the key. If provided, used only for validating correct key usage (optional)</param>
    /// <param name="memberId">member client id for signing CSRs. &lt;instance_id&gt;:&lt;member_class&gt;:&lt;member_code&gt; (optional)</param>
    /// <param name="isNewMember">whether or not the member in the member_id parameter is a new member (optional, default to false)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (List&lt;CsrSubjectFieldDescription&gt;)</returns>
    public async Task<ApiResponse<List<CsrSubjectFieldDescription>>> GetSubjectFieldDescriptionsWithHttpInfoAsync(
        string caName, KeyUsageType keyUsageType, string keyId = default, string memberId = default,
        bool? isNewMember = default, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'caName' is set
        if (caName == null)
            throw new ApiException(400,
                "Missing required parameter 'caName' when calling CertificateAuthoritiesApi->GetSubjectFieldDescriptions");


        var localVarRequestOptions = new RequestOptions();

        var contentTypes = Array.Empty<string>();

        // to determine the Accept header
        string[] accepts =
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        localVarRequestOptions.PathParameters.Add("ca_name", ClientUtils.ParameterToString(caName)); // path parameter
        if (keyId != null)
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "key_id", keyId));
        localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "key_usage_type", keyUsageType));
        if (memberId != null)
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "member_id", memberId));
        if (isNewMember != null)
            localVarRequestOptions.QueryParameters.Add(
                ClientUtils.ParameterToMultiMap("", "is_new_member", isNewMember));

        // authentication (ApiKeyAuth) required
        if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            localVarRequestOptions.HeaderParameters.Add("Authorization",
                Configuration.GetApiKeyWithPrefix("Authorization"));

        // make the HTTP request
        var localVarResponse = await AsynchronousClient
            .GetAsync<List<CsrSubjectFieldDescription>>("/certificate-authorities/{ca_name}/csr-subject-fields",
                localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

        if (ExceptionFactory?.Invoke("GetSubjectFieldDescriptions", localVarResponse) is { } exception)
            throw exception;

        return localVarResponse;
    }
}