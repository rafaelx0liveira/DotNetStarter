namespace DotNetStarter.Core.Factories;

public class MicroserviceArchitectureFactory : IArchitectureFactory
{
    public Dictionary<string, FolderStructure> GetStructure()
    {
        return new Dictionary<string, FolderStructure>
        {
            {
                FolderNamingPatternConstant.API, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.API,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Controllers },
                        new FolderStructure { Name = FolderNamingPatternConstant.DTOs },
                        new FolderStructure { Name = FolderNamingPatternConstant.Filters },
                        new FolderStructure { Name = FolderNamingPatternConstant.Middlewares },
                        new FolderStructure { Name = FolderNamingPatternConstant.Validators },
                    }
                }
            },
            {
                FolderNamingPatternConstant.Application, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Application,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Commands },
                        new FolderStructure { Name = FolderNamingPatternConstant.Events },
                        new FolderStructure { 
                            Name = FolderNamingPatternConstant.Interfaces,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Services }
                            }
                        },
                        new FolderStructure { Name = FolderNamingPatternConstant.Queries },
                        new FolderStructure { Name = FolderNamingPatternConstant.Services },
                    }
                }
            },
            {
                FolderNamingPatternConstant.Domain, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Domain,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Entities },
                        new FolderStructure { Name = FolderNamingPatternConstant.Events },
                        new FolderStructure { Name = FolderNamingPatternConstant.Exceptions },
                        new FolderStructure {
                            Name = FolderNamingPatternConstant.Interfaces,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Repositories },
                                new FolderStructure { Name = FolderNamingPatternConstant.Services },
                            }
                        },
                        new FolderStructure { Name = FolderNamingPatternConstant.ValueObjects },
                    }
                }
            },
            {
                FolderNamingPatternConstant.Infrastructure, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Infrastructure,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { 
                            Name = FolderNamingPatternConstant.Messaging,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Consumers },
                                new FolderStructure { Name = FolderNamingPatternConstant.Publishers },
                            }
                        },
                        new FolderStructure { 
                            Name = FolderNamingPatternConstant.Observability,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Logging },
                                new FolderStructure { Name = FolderNamingPatternConstant.Metrics },
                            }
                        },
                        new FolderStructure {
                            Name = FolderNamingPatternConstant.Persistence,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Configs },
                                new FolderStructure { Name = FolderNamingPatternConstant.Context },
                                new FolderStructure { Name = FolderNamingPatternConstant.Repositories },
                            }
                        },
                        new FolderStructure { Name = FolderNamingPatternConstant.Services },
                    }
                }
            },
            {
                FolderNamingPatternConstant.Tests, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Tests,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure {
                            Name = FolderNamingPatternConstant.API,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Controllers },
                                new FolderStructure { Name = FolderNamingPatternConstant.Middlewares },
                            }
                        },
                        new FolderStructure {
                            Name = FolderNamingPatternConstant.Application,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Commands },
                                new FolderStructure { Name = FolderNamingPatternConstant.Events },
                                new FolderStructure { Name = FolderNamingPatternConstant.Queries },
                            }
                        },
                        new FolderStructure {
                            Name = FolderNamingPatternConstant.Domain,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Entities },
                                new FolderStructure { Name = FolderNamingPatternConstant.Events },
                            }
                        },
                        new FolderStructure {
                            Name = FolderNamingPatternConstant.Infrastructure,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { 
                                    Name = FolderNamingPatternConstant.Messaging,
                                    SubFolders = new List<FolderStructure>
                                    {
                                        new FolderStructure { Name = FolderNamingPatternConstant.Consumers },
                                        new FolderStructure { Name = FolderNamingPatternConstant.Publishers },
                                    }
                                },
                                new FolderStructure { Name = FolderNamingPatternConstant.Repositories },
                            }
                        }
                    }
                }
            }
        };
    }
}
