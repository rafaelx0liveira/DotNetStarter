namespace DotNetStarter.Core.Factories;

public class ProjectArchitectureFactoryCreator
{
    private readonly Dictionary<string, IArchitectureFactory> _factories;

    public ProjectArchitectureFactoryCreator(IEnumerable<IArchitectureFactory> factories)
        => _factories = factories
            .ToDictionary(factory => factory.GetType().Name.Replace("Factory", string.Empty)
            .ToLower());

    public IArchitectureFactory Create(string architecture)
    {
        if (_factories.TryGetValue(architecture.ToLower(), out var factory))
        {
            return factory;
        }

        throw new NotSupportedException($"Arquitetura '{architecture}' não é suportada.");
    }
}
