namespace Adobe.Target.Client
{
    using System;
    using System.Net;
    using Microsoft.Extensions.Logging;
    using Polly;
    using RestSharp;

    /// <summary>
    /// Target ClientConfig
    /// </summary>
    public sealed class ClientConfig
    {
        private const string ClusterPrefix = "mboxedge";
        private const string DeliveryPathSuffix = "/rest/v1/delivery";

        private ClientConfig()
        {
        }

        private ClientConfig(Builder builder)
        {
            ValidateConfig(builder);
            this.Client = builder.Client;
            this.OrganizationId = builder.OrganizationId;
            this.Protocol = builder.Secure ? "https://" : "http://";
            this.DefaultPropertyToken = builder.DefaultPropertyToken;
            this.DefaultUrl = this.Protocol + this.Client + "." + builder.ServerDomain + DeliveryPathSuffix;
            this.ClusterUrlPrefix = this.Protocol + ClusterPrefix;
            this.ClusterUrlSuffix = "." + builder.ServerDomain + DeliveryPathSuffix;
            this.Logger = builder.Logger;
            this.Timeout = builder.Timeout;
            this.Proxy = builder.Proxy;
            this.RetryPolicy = builder.RetryPolicy;
            this.AsyncRetryPolicy = builder.AsyncRetryPolicy;
        }

        /// <summary>
        /// Client
        /// </summary>
        public string Client { get; }

        /// <summary>
        /// OrganizationId
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// Protocol
        /// </summary>
        public string Protocol { get; }

        /// <summary>
        /// DefaultUrl
        /// </summary>
        public string DefaultUrl { get; }

        /// <summary>
        /// ClusterUrlPrefix
        /// </summary>
        public string ClusterUrlPrefix { get; }

        /// <summary>
        /// ClusterUrlSuffix
        /// </summary>
        public string ClusterUrlSuffix { get; }

        /// <summary>
        /// Default Property Token
        /// </summary>
        public string DefaultPropertyToken { get; }

        /// <summary>
        /// Logger
        /// </summary>
        public ILogger Logger { get; }

        /// <summary>
        /// Timeout (defaults to 100000 ms)
        /// </summary>
        public int Timeout { get; }

        /// <summary>
        /// Proxy
        /// </summary>
        public WebProxy Proxy { get; }

        /// <summary>
        /// Retry Policy
        /// </summary>
        public Policy<IRestResponse> RetryPolicy { get; }

        /// <summary>
        /// Async Retry Policy
        /// </summary>
        public AsyncPolicy<IRestResponse> AsyncRetryPolicy { get; }

        private static void ValidateConfig(Builder builder)
        {
            if (builder.Client == null)
            {
                throw new ArgumentException("Client cannot be null");
            }

            if (builder.OrganizationId == null)
            {
                throw new ArgumentException("OrganizationId cannot be null");
            }
        }

        /// <summary>
        /// Target ClientConfig Builder
        /// </summary>
        public sealed class Builder
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Builder"/> class.
            /// </summary>
            /// <param name="client">Client</param>
            /// <param name="organizationId">OrganizationId</param>
            public Builder(string client, string organizationId)
            {
                this.Client = client;
                this.OrganizationId = organizationId;
            }

            /// <summary>
            /// Client
            /// </summary>
            internal string Client { get; private set; }

            /// <summary>
            /// OrganizationId
            /// </summary>
            internal string OrganizationId { get; private set; }

            /// <summary>
            /// ServerDomain
            /// </summary>
            internal string ServerDomain { get; private set; } = "tt.omtrdc.net";

            /// <summary>
            /// DefaultPropertyToken
            /// </summary>
            internal string DefaultPropertyToken { get; private set; }

            /// <summary>
            /// Secure
            /// </summary>
            internal bool Secure { get; private set; } = true;

            /// <summary>
            /// Logger
            /// </summary>
            internal ILogger Logger { get; private set; }

            /// <summary>
            /// Timeout
            /// </summary>
            internal int Timeout { get; private set; } = 100000;

            /// <summary>
            /// Proxy
            /// </summary>
            internal WebProxy Proxy { get; private set; }

            /// <summary>
            /// Retry Policy
            /// </summary>
            internal Policy<IRestResponse> RetryPolicy { get; private set; }

            /// <summary>
            /// Async Retry Policy
            /// </summary>
            internal AsyncPolicy<IRestResponse> AsyncRetryPolicy { get; private set; }

            /// <summary>
            /// Sets ServerDomain
            /// </summary>
            /// <param name="serverDomain">ServerDomain</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetServerDomain(string serverDomain)
            {
                this.ServerDomain = serverDomain;
                return this;
            }

            /// <summary>
            /// Sets DefaultPropertyToken
            /// </summary>
            /// <param name="defaultPropertyToken">DefaultPropertyToken</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetDefaultPropertyToken(string defaultPropertyToken)
            {
                this.DefaultPropertyToken = defaultPropertyToken;
                return this;
            }

            /// <summary>
            /// Sets Secure
            /// </summary>
            /// <param name="secure">Secure</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetSecure(bool secure)
            {
                this.Secure = secure;
                return this;
            }

            /// <summary>
            /// Sets Logger
            /// </summary>
            /// <param name="logger">Logger</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetLogger(ILogger logger)
            {
                this.Logger = logger;
                return this;
            }

            /// <summary>
            /// Sets Timeout (defaults to 100000 ms)
            /// </summary>
            /// <param name="timeout">Timeout</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetTimeout(int timeout)
            {
                this.Timeout = timeout;
                return this;
            }

            /// <summary>
            /// Sets Proxy
            /// </summary>
            /// <param name="proxy">Proxy</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetProxy(WebProxy proxy)
            {
                this.Proxy = proxy;
                return this;
            }

            /// <summary>
            /// Sets Retry Policy
            /// </summary>
            /// <param name="retryPolicy">Retry Policy</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetRetryPolicy(Policy<IRestResponse> retryPolicy)
            {
                this.RetryPolicy = retryPolicy;
                return this;
            }

            /// <summary>
            /// Sets Async Retry Policy
            /// </summary>
            /// <param name="asyncRetryPolicy">Async Retry Policy</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetRetryPolicy(AsyncPolicy<IRestResponse> asyncRetryPolicy)
            {
                this.AsyncRetryPolicy = asyncRetryPolicy;
                return this;
            }

            /// <summary>
            /// Builds the <see cref="ClientConfig"/>
            /// </summary>
            /// <returns>Built <see cref="ClientConfig"/></returns>
            public ClientConfig Build()
            {
                return new ClientConfig(this);
            }
        }
    }
}