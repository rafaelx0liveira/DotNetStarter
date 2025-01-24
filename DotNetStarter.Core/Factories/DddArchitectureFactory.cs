using DotNetStarter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Factories
{
    public class DddArchitectureFactory : IArchitectureFactory
    {
        public Dictionary<string, string[]> GetStructure()
        {
            return new Dictionary<string, string[]>
            {
                { "Application", new[] { "Commands", "Queries", "Services" } },
                { "Domain", new[] { "Aggregates", "Entities", "ValueObjects", "Events" } },
                { "Infrastructure", new[] { "Persistence", "Repositories", "Services" } },
                { "Tests", new[] { "UnitTests", "IntegrationTests" } }
            };
        }
    }
}
