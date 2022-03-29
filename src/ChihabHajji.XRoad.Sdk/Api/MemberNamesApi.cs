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
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Model;

namespace ChihabHajji.XRoad.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMemberNamesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// find member name by member class and member code
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator looks up member&#39;s name.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberClass">class of the member</param>
        /// <param name="memberCode">code of the member</param>
        /// <returns>MemberName</returns>
        MemberName FindMemberName(string memberClass, string memberCode);

        /// <summary>
        /// find member name by member class and member code
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator looks up member&#39;s name.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberClass">class of the member</param>
        /// <param name="memberCode">code of the member</param>
        /// <returns>ApiResponse of MemberName</returns>
        ApiResponse<MemberName> FindMemberNameWithHttpInfo(string memberClass, string memberCode);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMemberNamesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// find member name by member class and member code
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator looks up member&#39;s name.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberClass">class of the member</param>
        /// <param name="memberCode">code of the member</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MemberName</returns>
        System.Threading.Tasks.Task<MemberName> FindMemberNameAsync(string memberClass, string memberCode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// find member name by member class and member code
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator looks up member&#39;s name.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberClass">class of the member</param>
        /// <param name="memberCode">code of the member</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MemberName)</returns>
        System.Threading.Tasks.Task<ApiResponse<MemberName>> FindMemberNameWithHttpInfoAsync(string memberClass, string memberCode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMemberNamesApi : IMemberNamesApiSync, IMemberNamesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MemberNamesApi : IMemberNamesApi
    {
        private ChihabHajji.XRoad.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberNamesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MemberNamesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberNamesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MemberNamesApi(string basePath)
        {
            this.Configuration = ChihabHajji.XRoad.Sdk.Client.Configuration.MergeConfigurations(
                ChihabHajji.XRoad.Sdk.Client.GlobalConfiguration.Instance,
                new ChihabHajji.XRoad.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ChihabHajji.XRoad.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ChihabHajji.XRoad.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ChihabHajji.XRoad.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberNamesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MemberNamesApi(ChihabHajji.XRoad.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ChihabHajji.XRoad.Sdk.Client.Configuration.MergeConfigurations(
                ChihabHajji.XRoad.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ChihabHajji.XRoad.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ChihabHajji.XRoad.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ChihabHajji.XRoad.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberNamesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MemberNamesApi(ChihabHajji.XRoad.Sdk.Client.ISynchronousClient client, ChihabHajji.XRoad.Sdk.Client.IAsynchronousClient asyncClient, ChihabHajji.XRoad.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ChihabHajji.XRoad.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ChihabHajji.XRoad.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ChihabHajji.XRoad.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ChihabHajji.XRoad.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ChihabHajji.XRoad.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// find member name by member class and member code &lt;h3&gt;Administrator looks up member&#39;s name.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberClass">class of the member</param>
        /// <param name="memberCode">code of the member</param>
        /// <returns>MemberName</returns>
        public MemberName FindMemberName(string memberClass, string memberCode)
        {
            ChihabHajji.XRoad.Sdk.Client.ApiResponse<MemberName> localVarResponse = FindMemberNameWithHttpInfo(memberClass, memberCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// find member name by member class and member code &lt;h3&gt;Administrator looks up member&#39;s name.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberClass">class of the member</param>
        /// <param name="memberCode">code of the member</param>
        /// <returns>ApiResponse of MemberName</returns>
        public ChihabHajji.XRoad.Sdk.Client.ApiResponse<MemberName> FindMemberNameWithHttpInfo(string memberClass, string memberCode)
        {
            // verify the required parameter 'memberClass' is set
            if (memberClass == null)
            {
                throw new ChihabHajji.XRoad.Sdk.Client.ApiException(400, "Missing required parameter 'memberClass' when calling MemberNamesApi->FindMemberName");
            }

            // verify the required parameter 'memberCode' is set
            if (memberCode == null)
            {
                throw new ChihabHajji.XRoad.Sdk.Client.ApiException(400, "Missing required parameter 'memberCode' when calling MemberNamesApi->FindMemberName");
            }

            ChihabHajji.XRoad.Sdk.Client.RequestOptions localVarRequestOptions = new ChihabHajji.XRoad.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(ChihabHajji.XRoad.Sdk.Client.ClientUtils.ParameterToMultiMap("", "member_class", memberClass));
            localVarRequestOptions.QueryParameters.Add(ChihabHajji.XRoad.Sdk.Client.ClientUtils.ParameterToMultiMap("", "member_code", memberCode));

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MemberName>("/member-names", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FindMemberName", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// find member name by member class and member code &lt;h3&gt;Administrator looks up member&#39;s name.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberClass">class of the member</param>
        /// <param name="memberCode">code of the member</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MemberName</returns>
        public async System.Threading.Tasks.Task<MemberName> FindMemberNameAsync(string memberClass, string memberCode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChihabHajji.XRoad.Sdk.Client.ApiResponse<MemberName> localVarResponse = await FindMemberNameWithHttpInfoAsync(memberClass, memberCode, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// find member name by member class and member code &lt;h3&gt;Administrator looks up member&#39;s name.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberClass">class of the member</param>
        /// <param name="memberCode">code of the member</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MemberName)</returns>
        public async System.Threading.Tasks.Task<ChihabHajji.XRoad.Sdk.Client.ApiResponse<MemberName>> FindMemberNameWithHttpInfoAsync(string memberClass, string memberCode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'memberClass' is set
            if (memberClass == null)
            {
                throw new ChihabHajji.XRoad.Sdk.Client.ApiException(400, "Missing required parameter 'memberClass' when calling MemberNamesApi->FindMemberName");
            }

            // verify the required parameter 'memberCode' is set
            if (memberCode == null)
            {
                throw new ChihabHajji.XRoad.Sdk.Client.ApiException(400, "Missing required parameter 'memberCode' when calling MemberNamesApi->FindMemberName");
            }


            ChihabHajji.XRoad.Sdk.Client.RequestOptions localVarRequestOptions = new ChihabHajji.XRoad.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ChihabHajji.XRoad.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(ChihabHajji.XRoad.Sdk.Client.ClientUtils.ParameterToMultiMap("", "member_class", memberClass));
            localVarRequestOptions.QueryParameters.Add(ChihabHajji.XRoad.Sdk.Client.ClientUtils.ParameterToMultiMap("", "member_code", memberCode));

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<MemberName>("/member-names", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FindMemberName", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
