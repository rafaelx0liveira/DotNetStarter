namespace DotNetStarter.Core.Factories;

public class DddArchitectureFactory : IArchitectureFactory
{
    public Dictionary<string, FolderStructure> GetStructure()
    {
        return new Dictionary<string, FolderStructure>
        {
            {
                "Application", new FolderStructure
                {
                    Name = "Application",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "Commands" },
                        new FolderStructure { Name = "DTOs" },
                        new FolderStructure { 
                            Name = "Interfaces",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure {Name = "Services"}
                            }
                        },
                        new FolderStructure { Name = "Queries" },
                        new FolderStructure { Name = "Services" },
                        new FolderStructure { Name = "Validators" },
                    }
                }
            },
            {
                "Domain", new FolderStructure
                {
                    Name = "Domain",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "Aggregates" },
                        new FolderStructure
                        {
                            Name = "Entities",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Base" },
                                new FolderStructure { Name = "Utils" }
                            }
                        },
                        new FolderStructure { Name = "Events" },
                        new FolderStructure { Name = "Exceptions" },
                        new FolderStructure
                        {
                            Name = "Interfaces",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Repositories" },
                                new FolderStructure { Name = "Services" }
                            }
                        },
                        new FolderStructure { Name = "ValueObjects" },
                    }
                }
            },
            {
                "Infrastructure", new FolderStructure
                {
                    Name = "Infrastructure",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = "Persistence",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Configs" },
                                new FolderStructure { Name = "Context" },
                                new FolderStructure { Name = "Repositories" },
                            }
                        },
                        new FolderStructure { Name = "Services" },
                    }
                }
            },
            {
                "Presentation", new FolderStructure
                {
                    Name = "Presentation",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "Controllers"},
                        new FolderStructure { Name = "Filters" }
                    }
                }
            },
            {
                "Tests", new FolderStructure
                {
                    Name = "Tests",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = "Application",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Commands" },
                                new FolderStructure { Name = "Queries" },
                                new FolderStructure { Name = "Services" }
                            }
                        },
                        new FolderStructure
                        {
                            Name = "Domain",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Aggregates" },
                                new FolderStructure { Name = "Entities" },
                            }
                        },
                        new FolderStructure { Name = "Repositories" }
                    }
                }
            }
        };
    }
}
