namespace DotNetStarter.Core.Factories;

public class CleanArchitectureFactory : IArchitectureFactory
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
                        new FolderStructure { Name = "DTOs" },
                        new FolderStructure { Name = "Interfaces" },
                        new FolderStructure { Name = "UseCases" },
                    }
                }
            },
            {
                "Domain", new FolderStructure
                {
                    Name = "Domain",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "Entities" },
                        new FolderStructure { Name = "Interfaces" },
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
                        new FolderStructure { Name = "Context"},
                        new FolderStructure { Name = "Migrations"},
                        new FolderStructure { Name = "Repositories"},
                    }
                }
            },
            {
                "CrossCutting", new FolderStructure
                {
                    Name = "CrossCutting",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "DependencyInjection"},
                    }
                }
            },
            {
                "Tests", new FolderStructure
                {
                    Name = "Tests",
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = "UseCases"},
                    }
                }
            }
        };
    }
}
