using DotNetStarter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Factories
{
    public class CleanArchitectureFactory : IArchitectureFactory
    {
        public Dictionary<string, string[]> GetStructure()
        {
            return new Dictionary<string, string[]>
            {
                { "Application", new[] { "DTOs", "Interfaces", "Services", "UseCases" } },
                { "Domain", new[] { "Entities", "Interfaces", "ValueObjects" } },
                { "Infrastructure", new[] { "Context", "Migrations", "Repositories" } },
                { "CrossCutting", new[] { "DependencyInjection" } },
                { "Tests", new[] { "UnitTests" } }
            };
        }
    }
}
