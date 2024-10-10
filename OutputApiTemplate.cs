// Models/InputApiTemplate.cs
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace ApiTemplateTransformer.Models
{
    public class InputApiTemplate
    {
        public Id id { get; set; }
        public string uuid { get; set; }
        public string type { get; set; }
        public string context { get; set; }
        public string contextTemplate { get; set; }
        public List<string> tags { get; set; }
        public List<object> documents { get; set; }
        public DateTime lastUpdated { get; set; }
        public List<ApiTier> availableTiers { get; set; }
        public List<object> availableSubscriptionLevelPolicies { get; set; }
        public List<object> uriTemplates { get; set; }
        public bool apiHeaderChanged { get; set; }
        public bool apiResourcePatternsChanged { get; set; }
        public string status { get; set; }
        public string visibility { get; set; }
        public List<GatewayLabel> gatewayLabels { get; set; }
        public bool endpointSecured { get; set; }
        public bool endpointAuthDigest { get; set; }
        public string transports { get; set; }
        public bool advertiseOnly { get; set; }
        public string subscriptionAvailability { get; set; }
        public CorsConfiguration corsConfiguration { get; set; }
        public string endpointConfig { get; set; }
        public string responseCache { get; set; }
        public string cacheTimeout { get; set; }
        public string implementation { get; set; }
        public string authorizationHeader { get; set; }
        public List<string> scopes { get; set; }
        public bool isDefaultVersion { get; set; }
        public bool isPublishedDefaultVersion { get; set; }
        public List<string> environments { get; set; }
        public long createdTime { get; set; }
        public Dictionary<string, object> additionalProperties { get; set; }
        public Dictionary<string, object> monetizationProperties { get; set; }
        public bool isMonetizationEnabled { get; set; }
        public List<string> environmentList { get; set; }
        public string apiSecurity { get; set; }
        public List<object> endpoints { get; set; }
        public bool enableSchemaValidation { get; set; }
        public List<object> apiCategories { get; set; }
        public string accessControl { get; set; }
        public double rating { get; set; }
        public bool isLatest { get; set; }
    }
    public class Id
    {
        public string providerName { get; set; }
        public string apiName { get; set; }
        public string version { get; set; }
    }

    public class ApiTier
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public int requestsPerMin { get; set; }
        public int requestCount { get; set; }
        public int unitTime { get; set; }
        public string timeUnit { get; set; }
        public string tierPlan { get; set; }
        public bool stopOnQuotaReached { get; set; }
    }

    public class GatewayLabel
    {
        public string name { get; set; }
        public string description { get; set; }
        public List<string> accessUrls { get; set; }
    }

    public class CorsConfiguration
    {

        public bool accessControlAllowCredentials { get; set; }
        public List<string> accessControlAllowHeaders { get; set; }
        public List<string> accessControlAllowMethods { get; set; }
        public List<string> accessControlAllowOrigins { get; set; }
        public bool corsConfigurationEnabled { get; set; }
    }

    public class OutputApiTemplate
    {
        public string type { get; set; }
        public string version { get; set; }
        public OutputData data { get; set; }
    }

    public class OutputData
    {
        public string name { get; set; }
        public string context { get; set; }
        public string version { get; set; }
        public string provider { get; set; }
        public string lifeCycleStatus { get; set; }
        public bool isDefaultVersion { get; set; }
        public bool isRevision { get; set; }
        public int revisionId { get; set; }
        public string type { get; set; }
        public List<string> transport { get; set; }
        public List<string> policies { get; set; }
        public string visibility { get; set; }
        public CorsConfiguration corsConfiguration { get; set; }
        public EndpointConfig endpointConfig { get; set; }
        public string responseCache { get; set; }
        public string authorizationHeader { get; set; }
        public List<string> scopes { get; set; }
        public string endpointImplementationType { get; set; }
        public string websubSubscriptionConfiguration { get; set; } = null; // Change to appropriate type if needed
    }

    public class EndpointConfig
    {
        public string endpointType { get; set; }
        public Endpoints productionEndpoints { get; set; }
        public Endpoints sandboxEndpoints { get; set; }
    }

    public class Endpoints
    {
        public string url { get; set; }
    }
}
