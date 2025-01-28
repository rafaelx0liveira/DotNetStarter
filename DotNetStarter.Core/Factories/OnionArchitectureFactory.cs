namespace DotNetStarter.Core.Factories;

public class OnionArchitectureFactory : IArchitectureFactory
{
    public Dictionary<string, FolderStructure> GetStructure()
    {
        return new Dictionary<string, FolderStructure>
        {
            {
                "API",
                new FolderStructure
                {
                    Name = "API",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "Controllers" },
                        new FolderStructure { Name = "Middlewares" },
                    }
                }
            },
            {
                "Core",
                new FolderStructure
                {
                    Name = "Core",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = "Application",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Interfaces" },
                                new FolderStructure { Name = "BusinessServices" },
                            }
                        },
                        new FolderStructure
                        {
                            Name = "Domain",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Entities" },
                                new FolderStructure { Name = "Events" },
                                new FolderStructure { Name = "Exceptions" },
                                new FolderStructure { Name = "ValueObjects" },
                            }
                        },
                        new FolderStructure
                        {
                            Name = "SharedKernel",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Enums" },
                                new FolderStructure { Name = "Events" },
                                new FolderStructure { Name = "utils" }
                            }
                        }
                    }
                }
            },
            {
                "Infrastructure",
                new FolderStructure
                {
                    Name = "Infrastructure",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "Configs" },
                        new FolderStructure { Name = "Logging" },
                        new FolderStructure
                        {
                            Name = "Messaging",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Consumers" },
                                new FolderStructure { Name = "Publishers" },
                            }
                        },
                        new FolderStructure
                        {
                            Name = "Persistence",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Context" },
                                new FolderStructure { Name = "Repositories" },
                            }
                        }
                    }
                }
            },
            {
                "Tests",
                new FolderStructure
                {
                    Name = "Tests",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = "API",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Controllers" },
                                new FolderStructure { Name = "Middlewares" },
                            }
                        },
                        new FolderStructure { Name = "Core" },
                        new FolderStructure
                        {
                            Name = "Infrastructure",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure
                                {
                                    Name = "Messaging",
                                    SubFolders = new List<FolderStructure>
                                    {
                                        new FolderStructure { Name = "Consumers" },
                                        new FolderStructure { Name = "Publishers" },
                                    }
                                },
                                new FolderStructure
                                {
                                    Name = "Persistence",
                                    SubFolders = new List<FolderStructure>
                                    {
                                        new FolderStructure { Name = "Repositories" },
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
