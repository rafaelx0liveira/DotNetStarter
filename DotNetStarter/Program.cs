public class Program
{
    public static void Main(string[] args)
    {
        // Configura o container de DI
        var services = new ServiceCollection();

        // Registra serviços e dependências
        ConfigureServices(services);

        // Constrói o service provider
        var serviceProvider = services.BuildServiceProvider();

        // Executa a aplicação
        var executor = serviceProvider.GetRequiredService<CommandExecutor>();
        executor.Execute(args);
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        // Registra as factories específicas
        services.AddSingleton<IArchitectureFactory, CleanArchitectureFactory>();
        services.AddSingleton<IArchitectureFactory, CQRSArchitectureFactory>();
        services.AddSingleton<IArchitectureFactory, DddArchitectureFactory>();
        services.AddSingleton<IArchitectureFactory, HexagonalArchitectureFactory>();
        services.AddSingleton<IArchitectureFactory, MicroserviceArchitectureFactory>();
        services.AddSingleton<IArchitectureFactory, OnionArchitectureFactory>();

        // Registra o Factory Creator
        services.AddSingleton<ProjectArchitectureFactoryCreator>();

        // Registra o Builder
        services.AddSingleton<ProjectStructureBuilder>();

        // Registra o ProjectGenerator
        services.AddTransient<ProjectGeneratorService>();

        // Registra os comandos
        services.AddTransient<InitCommand>();
        services.AddTransient<ListCommand>();
        services.AddTransient<HelpCommand>();

        // Registra o CommandExecutor
        services.AddSingleton<CommandExecutor>();
    }
}
