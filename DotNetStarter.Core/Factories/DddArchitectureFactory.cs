namespace DotNetStarter.Core.Factories;

public class DddArchitectureFactory : IArchitectureFactory
{
    public Dictionary<string, FolderStructure> GetStructure()
    {
        return new Dictionary<string, FolderStructure>
        {
            {
                FolderNamingPatternConstant.Application, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Application,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Commands },
                        new FolderStructure { Name = FolderNamingPatternConstant.DTOs },
                        new FolderStructure { 
                            Name = FolderNamingPatternConstant.Interfaces,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure {Name = FolderNamingPatternConstant.Services }
                            }
                        },
                        new FolderStructure { Name = FolderNamingPatternConstant.Queries },
                        new FolderStructure { Name = FolderNamingPatternConstant.Services },
                        new FolderStructure { Name = FolderNamingPatternConstant.Validators },
                    }
                }
            },
            {
                FolderNamingPatternConstant.Domain, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Domain,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Aggregates },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Entities,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Base },
                                new FolderStructure { Name = FolderNamingPatternConstant.Utils }
                            }
                        },
                        new FolderStructure { Name = FolderNamingPatternConstant.Events },
                        new FolderStructure { Name = FolderNamingPatternConstant.Exceptions },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Interfaces,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Repositories },
                                new FolderStructure { Name = FolderNamingPatternConstant.Services }
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
                        new FolderStructure
                        {
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
                FolderNamingPatternConstant.Presentation, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Presentation,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.Controllers},
                        new FolderStructure { Name = FolderNamingPatternConstant.Filters }
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
                            Name = FolderNamingPatternConstant.Application,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Commands },
                                new FolderStructure { Name = FolderNamingPatternConstant.Queries },
                                new FolderStructure { Name = FolderNamingPatternConstant.Services }
                            }
                        },
                        new FolderStructure
                        {
                            Name = FolderNamingPatternConstant.Domain,
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = FolderNamingPatternConstant.Aggregates },
                                new FolderStructure { Name = FolderNamingPatternConstant.Entities },
                            }
                        },
                        new FolderStructure { Name = FolderNamingPatternConstant.Repositories }
                    }
                }
            }
        };
    }
}
