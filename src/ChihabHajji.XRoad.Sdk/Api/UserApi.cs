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
    public interface IUserApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// get user data for the logged user
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator gets user data from backend.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>User</returns>
        User GetUser();

        /// <summary>
        /// get user data for the logged user
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator gets user data from backend.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetUserWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// get user data for the logged user
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator gets user data from backend.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get user data for the logged user
        /// </summary>
        /// <remarks>
        /// &lt;h3&gt;Administrator gets user data from backend.&lt;/h3&gt;
        /// </remarks>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApi : IUserApiSync, IUserApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserApi : IUserApi
    {
        private ChihabHajji.XRoad.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(string basePath)
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
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserApi(ChihabHajji.XRoad.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UserApi(ChihabHajji.XRoad.Sdk.Client.ISynchronousClient client, ChihabHajji.XRoad.Sdk.Client.IAsynchronousClient asyncClient, ChihabHajji.XRoad.Sdk.Client.IReadableConfiguration configuration)
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
        /// get user data for the logged user &lt;h3&gt;Administrator gets user data from backend.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>User</returns>
        public User GetUser()
        {
            ChihabHajji.XRoad.Sdk.Client.ApiResponse<User> localVarResponse = GetUserWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// get user data for the logged user &lt;h3&gt;Administrator gets user data from backend.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of User</returns>
        public ChihabHajji.XRoad.Sdk.Client.ApiResponse<User> GetUserWithHttpInfo()
        {
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


            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<User>("/user", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUser", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// get user data for the logged user &lt;h3&gt;Administrator gets user data from backend.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChihabHajji.XRoad.Sdk.Client.ApiResponse<User> localVarResponse = await GetUserWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get user data for the logged user &lt;h3&gt;Administrator gets user data from backend.&lt;/h3&gt;
        /// </summary>
        /// <exception cref="ChihabHajji.XRoad.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ChihabHajji.XRoad.Sdk.Client.ApiResponse<User>> GetUserWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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


            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<User>("/user", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUser", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
