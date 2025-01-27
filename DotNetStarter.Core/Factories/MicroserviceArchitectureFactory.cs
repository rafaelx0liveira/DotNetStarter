using DotNetStarter.Core.Entities;
using DotNetStarter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Factories
{
    public class MicroserviceArchitectureFactory : IArchitectureFactory
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
                            new FolderStructure { Name = "DTOs" },
                            new FolderStructure { Name = "Filters" },
                            new FolderStructure { Name = "Middlewares" },
                            new FolderStructure { Name = "Validators" },
                        }
                    }
                },
                {
                    "Application", new FolderStructure
                    {
                        Name = "Application",
                        SubFolders = new List<FolderStructure>
                        {
                            new FolderStructure { Name = "Commands" },
                            new FolderStructure { Name = "Events" },
                            new FolderStructure { 
                                Name = "Interfaces",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Services" }
                                }
                            },
                            new FolderStructure { Name = "Queries" },
                            new FolderStructure { Name = "Services" },
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
                            new FolderStructure { Name = "Events" },
                            new FolderStructure { Name = "Exceptions" },
                            new FolderStructure {
                                Name = "Interfaces",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Repositories" },
                                    new FolderStructure { Name = "Services" },
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
                            new FolderStructure { 
                                Name = "Messaging",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Consumers" },
                                    new FolderStructure { Name = "Publishers" },
                                }
                            },
                            new FolderStructure { 
                                Name = "Observability",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Logging" },
                                    new FolderStructure { Name = "Metrics" },
                                }
                            },
                            new FolderStructure {
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
                    "Tests", new FolderStructure
                    {
                        Name = "Tests",
                        SubFolders = new List<FolderStructure>
                        {
                            new FolderStructure {
                                Name = "API",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Controllers" },
                                    new FolderStructure { Name = "Middlewares" },
                                }
                            },
                            new FolderStructure {
                                Name = "Application",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Commands" },
                                    new FolderStructure { Name = "Events" },
                                    new FolderStructure { Name = "Queries" },
                                }
                            },
                            new FolderStructure {
                                Name = "Domain",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { Name = "Entities" },
                                    new FolderStructure { Name = "Events" },
                                }
                            },
                            new FolderStructure {
                                Name = "Infrastructure",
                                SubFolders = new List<FolderStructure>
                                {
                                    new FolderStructure { 
                                        Name = "Messaging",
                                        SubFolders = new List<FolderStructure>
                                        {
                                            new FolderStructure { Name = "Consumers" },
                                            new FolderStructure { Name = "Publishers" },
                                        }
                                    },
                                    new FolderStructure { Name = "Repositories" },
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
