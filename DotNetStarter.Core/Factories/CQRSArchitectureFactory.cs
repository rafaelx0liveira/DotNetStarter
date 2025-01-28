namespace DotNetStarter.Core.Factories;

public class CQRSArchitectureFactory : IArchitectureFactory
{
    public Dictionary<string, FolderStructure> GetStructure()
    {
        return new Dictionary<string, FolderStructure>
        {
            { 
                "API", new FolderStructure
                {
                    Name = "API",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "Controllers" },
                        new FolderStructure { Name = "Middlewares" }
                    }
                }
            },
            { "CommandSide", new FolderStructure
                {
                    Name = "CommandSide",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = "Application",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Commands" },
                                new FolderStructure { Name = "Handlers" },
                                new FolderStructure { Name = "Validators" }
                            }
                        },
                        new FolderStructure
                        {
                            Name = "Domain",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Aggregates" },
                                new FolderStructure { Name = "Entities" },
                                new FolderStructure { Name = "Events" },
                                new FolderStructure { Name = "Exceptions" }
                            }
                        },
                        new FolderStructure
                        {
                            Name = "Infrastructure",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "EventStore" },
                                new FolderStructure { Name = "Persistence" },
                                new FolderStructure { Name = "Repositories" }
                            }
                        }
                    }
                }
            },
            { "QuerySide", new FolderStructure
                {
                    Name = "QuerySide",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure
                        {
                            Name = "Application",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "Handlers" },
                                new FolderStructure { Name = "Queries" }
                            }
                        },
                        new FolderStructure
                        {
                            Name = "Infrastructure",
                            SubFolders = new List<FolderStructure>
                            {
                                new FolderStructure { Name = "ReadModels" },
                                new FolderStructure { Name = "Repositories" }
                            }
                        }
                    }
                }
            },
            { "Shared", new FolderStructure
                {
                    Name = "Shared",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "Events" },
                        new FolderStructure { Name = "Utils" }
                    }
                }
            },
            { "Tests", new FolderStructure
                {
                    Name = "Tests",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "CommandSide" },
                        new FolderStructure { Name = "QuerySide" },
                        new FolderStructure { Name = "Shared" }
                    }
                }
            }
        };
    }
}
