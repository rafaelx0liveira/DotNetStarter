using DotNetStarter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Factories
{
    public class ProjectArchitectureFactoryCreator
    {
        private readonly Dictionary<string, IArchitectureFactory> _factories;

        public ProjectArchitectureFactoryCreator(IEnumerable<IArchitectureFactory> factories)
        {
            _factories = factories.ToDictionary(factory => factory.GetType().Name.Replace("Factory", "").ToLower());
        }

        public IArchitectureFactory Create(string architecture)
        {
            if (_factories.TryGetValue(architecture.ToLower(), out var factory))
            {
                return factory;
            }

            throw new NotSupportedException($"Arquitetura '{architecture}' não é suportada.");
        }
    }

}
