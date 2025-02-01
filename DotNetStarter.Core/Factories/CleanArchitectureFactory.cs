namespace DotNetStarter.Core.Factories;

public class CleanArchitectureFactory : IArchitectureFactory
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
                        new FolderStructure { Name = FolderNamingPatternConstant.DTOs },
                        new FolderStructure { Name = FolderNamingPatternConstant.Interfaces },
                        new FolderStructure { Name = FolderNamingPatternConstant.UseCases },
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
                        new FolderStructure { Name = FolderNamingPatternConstant.Interfaces },
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
                        new FolderStructure { Name = FolderNamingPatternConstant.Context },
                        new FolderStructure { Name = FolderNamingPatternConstant.Migrations },
                        new FolderStructure { Name = FolderNamingPatternConstant.Repositories },
                    }
                }
            },
            {
                FolderNamingPatternConstant.CrossCutting, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.CrossCutting,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.DependencyInjection },
                    }
                }
            },
            {
                FolderNamingPatternConstant.Tests, new FolderStructure
                {
                    Name = FolderNamingPatternConstant.Tests,
                    SubFolders = new List<FolderStructure>
                    {
                        new FolderStructure { Name = FolderNamingPatternConstant.UseCases },
                    }
                }
            }
        };
    }
}
