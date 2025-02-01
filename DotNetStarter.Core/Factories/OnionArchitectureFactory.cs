namespace DotNetStarter.Core.Factories;

public class OnionArchitectureFactory : IArchitectureFactory
{
    public Dictionary<string, FolderStructure> GetStructure()
    {
        return new Dictionary<string, FolderStructure>
        {
            {
                FolderNamingPatternConstant.API,
                new FolderStructure
                {
                    Name = FolderNamingPatternConstant.API,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Controllers },
                        new FolderStructure { Name = FolderNamingPatternConstant.Middlewares },
                    }
                }
            },
            {
                FolderNamingPatternConstant.Core,
                new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Core,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Application,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Interfaces },
                                new FolderStructure { Name = FolderNamingPatternConstant.BusinessServices },
                            }
                        },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Domain,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Entities },
                                new FolderStructure { Name = FolderNamingPatternConstant.Events },
                                new FolderStructure { Name = FolderNamingPatternConstant.Exceptions },
                                new FolderStructure { Name = FolderNamingPatternConstant.ValueObjects },
                            }
                        },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.SharedKernel,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Enums },
                                new FolderStructure { Name = FolderNamingPatternConstant.Events },
                                new FolderStructure { Name = FolderNamingPatternConstant.Utils }
                            }
                        }
                    }
                }
            },
            {
                FolderNamingPatternConstant.Infrastructure,
                new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Infrastructure,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Configs },
                        new FolderStructure { Name = FolderNamingPatternConstant.Logging },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Messaging,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Consumers },
                                new FolderStructure { Name = FolderNamingPatternConstant.Publishers },
                            }
                        },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Persistence,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Context },
                                new FolderStructure { Name = FolderNamingPatternConstant.Repositories },
                            }
                        }
                    }
                }
            },
            {
                FolderNamingPatternConstant.Tests,
                new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Tests,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.API,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Controllers },
                                new FolderStructure { Name = FolderNamingPatternConstant.Middlewares },
                            }
                        },
                        new FolderStructure { Name = FolderNamingPatternConstant.Core },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Infrastructure,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure
                                {
                                    Name = FolderNamingPatternConstant.Messaging,
                                    SubFolders = new List<FolderStructure>
                                    {
                                        new FolderStructure { Name = FolderNamingPatternConstant.Consumers },
                                        new FolderStructure { Name = FolderNamingPatternConstant.Publishers },
                                    }
                                },
                                new FolderStructure
                                {
                                    Name = FolderNamingPatternConstant.Persistence,
                                    SubFolders = new List<FolderStructure>
                                    {
                                        new FolderStructure { Name = FolderNamingPatternConstant.Repositories },
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
    }
}
