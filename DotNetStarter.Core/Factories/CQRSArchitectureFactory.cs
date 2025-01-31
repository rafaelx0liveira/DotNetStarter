namespace DotNetStarter.Core.Factories;

public class CQRSArchitectureFactory : IArchitectureFactory
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
                        new FolderStructure { Name = FolderNamingPatternConstant.Middlewares }
                    }
                }
            },
            { FolderNamingPatternConstant.CommandSide, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.CommandSide,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Application,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Commands },
                                new FolderStructure { Name = FolderNamingPatternConstant.Handlers },
                                new FolderStructure { Name = FolderNamingPatternConstant.Validators }
                            }
                        },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Domain,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Aggregates },
                                new FolderStructure { Name = FolderNamingPatternConstant.Entities },
                                new FolderStructure { Name = FolderNamingPatternConstant.Events },
                                new FolderStructure { Name = FolderNamingPatternConstant.Exceptions }
                            }
                        },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Infrastructure,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.EventStore },
                                new FolderStructure { Name = FolderNamingPatternConstant.Persistence },
                                new FolderStructure { Name = FolderNamingPatternConstant.Repositories }
                            }
                        }
                    }
                }
            },
            { FolderNamingPatternConstant.QuerySide, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.QuerySide,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Application,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Handlers },
                                new FolderStructure { Name = FolderNamingPatternConstant.Queries }
                            }
                        },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Infrastructure,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.ReadModels },
                                new FolderStructure { Name = FolderNamingPatternConstant.Repositories }
                            }
                        }
                    }
                }
            },
            { FolderNamingPatternConstant.Shared, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Shared,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Events },
                        new FolderStructure { Name = FolderNamingPatternConstant.Utils }
                    }
                }
            },
            { FolderNamingPatternConstant.Tests, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Tests,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.CommandSide },
                        new FolderStructure { Name = FolderNamingPatternConstant.QuerySide },
                        new FolderStructure { Name = FolderNamingPatternConstant.Shared }
                    }
                }
            }
        };
    }
}
