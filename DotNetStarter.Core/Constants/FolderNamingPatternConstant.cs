namespace DotNetStarter.Core.Constants;

/// <summary>
/// Constantes para os padrões de nomenclatura de pastas.
/// </summary>
public class FolderNamingPatternConstant
{
    protected FolderNamingPatternConstant() { }

    #region Shared

    public const string Aggregates = "Aggregates";
    public const string Application = "Application";
    public const string CommandSide = "CommandSide";
    public const string Commands = "Commands";
    public const string Context = "Context";
    public const string Controllers = "Controllers";
    public const string Domain = "Domain";
    public const string DTOs = "DTOs";
    public const string Entities = "Entities";
    public const string Events = "Events";
    public const string Exceptions = "Exceptions";
    public const string Handlers = "Handlers";
    public const string Infrastructure = "Infrastructure";
    public const string Logging = "Logging";
    public const string Persistence = "Persistence";
    public const string Repositories = "Repositories";
    public const string Shared = "Shared";
    public const string Tests = "Tests";
    public const string Utils = "Utils";
    public const string QuerySide = "QuerySide";
    public const string Queries = "Queries";
    public const string Validators = "Validators";

    #endregion

    #region Clean Architecture

    public const string Interfaces = "Interfaces";
    public const string UseCases = "UseCases";
    public const string ValueObjects = "ValueObjects";
    public const string Migrations = "Migrations";
    public const string CrossCutting = "CrossCutting";
    public const string DependencyInjection = "DependencyInjection";

    #endregion

    #region CQRS Architecture

    public const string API = "API";
    public const string Middlewares = "Middlewares";
    public const string EventStore = "EventStore";
    public const string ReadModels = "ReadModels";

    #endregion

    #region DDD Architecture

    public const string Services = "Services";
    public const string Base = "Base";
    public const string Configs = "Configs";
    public const string Presentation = "Presentation";
    public const string Filters = "Filters";

    #endregion

    #region Hexagonal Architecture
    
    public const string Adapters = "Adapters";
    public const string Inbound = "Inbound";
    public const string Messaging = "Messaging";
    public const string Outbound = "Outbound";
    public const string APIs = "APIs";
    public const string Configuration = "Configuration";
    public const string Consumers = "Consumers";
    public const string Publishers = "Publishers";

    #endregion

    #region Microservice Architecture

    public const string Observability = "Observability";
    public const string Metrics = "Metrics";

    #endregion

    #region Onion Architecture
    
    public const string Core = "Core";
    public const string BusinessServices = "BusinessServices";
    public const string SharedKernel = "SharedKernel";
    public const string Enums = "Enums";

    #endregion
}
