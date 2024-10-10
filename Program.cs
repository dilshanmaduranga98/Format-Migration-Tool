using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using ApiTemplateTransformer.Models;
// Paths to the input and output YAML files
string inputYamlFilePath = "data/api.yaml";  // Replace with your actual input file path
string outputYamlFilePath = "output/api.yaml"; // Replace with your desired output file path

// Read the input YAML file
var inputYaml = File.ReadAllText(inputYamlFilePath);

// Deserialize the input YAML
var deserializer = new DeserializerBuilder()
    .WithNamingConvention(CamelCaseNamingConvention.Instance)
    .Build();
var inputTemplate = deserializer.Deserialize<InputApiTemplate>(inputYaml);


// var corsDto = (CorsConfigurationDTO)corsConfiguration;

// Transform the data to fit the output structure
var outputTemplate = new OutputApiTemplate
{
    type = "api",
    version = "v4.2.0",
    data = new OutputData
    {
        name = inputTemplate.id.apiName,
        context = inputTemplate.context,
        version = inputTemplate.id.version,
        provider = inputTemplate.id.providerName,
        lifeCycleStatus = inputTemplate.status,
        isDefaultVersion = true,
        isRevision = false,
        revisionId = 0,
        type = inputTemplate.type,
        transport = new List<string>(inputTemplate.transports.Split(',')),
        policies = inputTemplate.availableTiers.ConvertAll(t => t.name),
        visibility = inputTemplate.visibility.ToUpper(),
        corsConfiguration = inputTemplate.corsConfiguration,
        endpointConfig = new EndpointConfig
        {
            endpointType = inputTemplate.type.ToLower(),
            productionEndpoints = new Endpoints
            {
                url = "https://dev-mi1.togocom.tg/accounts/v2" // Adjust URL as needed
            },
            sandboxEndpoints = new Endpoints
            {
                url = "https://dev-mi1.togocom.tg/accounts/v2" // Adjust URL as needed
            }
        },
        responseCache = "Disabled",
        authorizationHeader = inputTemplate.authorizationHeader,
        scopes = new List<string>(),
        endpointImplementationType = inputTemplate.implementation,
        websubSubscriptionConfiguration ="null" // Set to appropriate value if needed
    }
};

// Serialize the output template to YAML
var serializer = new SerializerBuilder()
    .WithNamingConvention(CamelCaseNamingConvention.Instance)
    .Build();
var outputYaml = serializer.Serialize(outputTemplate);

// Write the output YAML to a file
File.WriteAllText(outputYamlFilePath, outputYaml);

Console.WriteLine("********----YAML transformation completed successfully!----********");
