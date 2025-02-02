namespace DotNetStarter.Core.Factories;

public class HexagonalArchitectureFactory : IArchitectureFactory
{
    public Dictionary<string, FolderStructure> GetStructure()
    {
        return new Dictionary<string, FolderStructure>
        {
            {
                FolderNamingPatternConstant.Adapters, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Adapters,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Inbound,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Controllers },
                                new FolderStructure { Name = FolderNamingPatternConstant.Messaging },
                            }
                        },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Outbound,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.APIs },
                                new FolderStructure { Name = FolderNamingPatternConstant.Messaging },
                                new FolderStructure { Name = FolderNamingPatternConstant.Repositories }
                            }
                        }
                    }
                }
            },
            {
                FolderNamingPatternConstant.Application, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Application,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.DTOs},
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Interfaces,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Inbound },
                                new FolderStructure { Name = FolderNamingPatternConstant.Outbound }
                            }
                        },
                        new FolderStructure { Name = FolderNamingPatternConstant.Services }
                    }
                }
            },
            {
                FolderNamingPatternConstant.Domain, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Domain,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Entities},
                        new FolderStructure { Name = FolderNamingPatternConstant.Events },
                        new FolderStructure { Name = FolderNamingPatternConstant.Exceptions },
                        new FolderStructure { Name = FolderNamingPatternConstant.ValueObjects }
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
                            Name = FolderNamingPatternConstant.Configuration,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Logging },
                            }
                        },
                        new FolderStructure 
                        { 
                            Name = FolderNamingPatternConstant.Messaging,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Consumers },
                                new FolderStructure { Name = FolderNamingPatternConstant.Publishers }
                            }
                        },
                        new FolderStructure { 
                            Name = FolderNamingPatternConstant.Persistence,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Configs },
                                new FolderStructure { Name = FolderNamingPatternConstant.Context },
                                new FolderStructure { Name = FolderNamingPatternConstant.Repositories }
                            }
                        }
                    }
                }
            },
            {
                FolderNamingPatternConstant.Tests, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Tests,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Adapters,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Inbound },
                                new FolderStructure { Name = FolderNamingPatternConstant.Outbound },
                            }
                        },
                        new FolderStructure { 
                            Name = FolderNamingPatternConstant.Application,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Services },
                                new FolderStructure { Name = FolderNamingPatternConstant.DTOs }
                            }
                        },
                        new FolderStructure { Name = FolderNamingPatternConstant.Domain }
                    }
                }
            }
        };
    }
}
