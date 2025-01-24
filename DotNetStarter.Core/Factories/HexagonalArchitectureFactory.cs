using DotNetStarter.Core.Entities;
using DotNetStarter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Factories
{
    public class HexagonalArchitectureFactory : IArchitectureFactory
    {
        public Dictionary<string, FolderStructure> GetStructure()
        {
            return new Dictionary<string, FolderStructure>
            {
                {
                    "Adapters", new FolderStructure
                    {
                        Name = "Adapters",
                        SubFolders = new List<FolderStructure>
                        {
                            new FolderStructure
                            {
                                Name = "Inbound",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Controllers" },
                                    new FolderStructure { Name = "Messaging" },
                                }
                            },
                            new FolderStructure
                            {
                                Name = "Outbound",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "APIs" },
                                    new FolderStructure { Name = "Messaging" },
                                    new FolderStructure { Name = "Repositories" }
                                }
                            }
                        }
                    }
                },
                {
                    "Application", new FolderStructure
                    {
                        Name = "Application",
                        SubFolders = new List<FolderStructure>
                        {
                            new FolderStructure { Name = "DTOs"},
                            new FolderStructure
                            {
                                Name = "Interfaces",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Inbound" },
                                    new FolderStructure { Name = "Outbound" }
                                }
                            },
                            new FolderStructure { Name = "Services" }
                        }
                    }
                },
                {
                    "Domain", new FolderStructure
                    {
                        Name = "Domain",
                        SubFolders = new List<FolderStructure>
                        {
                            new FolderStructure { Name = "Entities"},
                            new FolderStructure { Name = "Events" },
                            new FolderStructure { Name = "Exceptions" },
                            new FolderStructure { Name = "ValueObjects" }
                        }
                    }
                },
                {
                    "Infrastructure", new FolderStructure
                    {
                        Name = "Infrastructure",
                        SubFolders = new List<FolderStructure>
                        {
                            new FolderStructure { 
                                Name = "Configuration",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Logging" },
                                }
                            },
                            new FolderStructure 
                            { 
                                Name = "Messaging",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Consumers" },
                                    new FolderStructure { Name = "Publishers" }
                                }
                            },
                            new FolderStructure { 
                                Name = "Persistence",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Configs" },
                                    new FolderStructure { Name = "Context" },
                                    new FolderStructure { Name = "Repositories" }
                                }
                            }
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
                                Name = "Adapters",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Inbound" },
                                    new FolderStructure { Name = "Outbound" },
                                }
                            },
                            new FolderStructure { 
                                Name = "Application",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Services" },
                                    new FolderStructure { Name = "DTOs" }
                                }
                            },
                            new FolderStructure { Name = "Domain" }
                        }
                    }
                }
            };
        }
    }
}
