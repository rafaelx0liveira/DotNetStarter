using DotNetStarter.Core;
using Spectre.Console;

public class Program
{
    public static void Main(string[] args)
    {
        var command = args.Length > 0 ? args[0] : "help";

        switch (command)
        {
            case "init":
                var architecture = args.Length > 1 ? args[1] : "clean";
                var outputPath = AnsiConsole.Ask<string>("Output directory [[default: current]]:", ".");

                try
                {
                    ProjectGenerator.CreateProject(architecture, outputPath);
                    AnsiConsole.Markup("[green]Project created successfully![/]");
                }
                catch (Exception ex)
                {
                    AnsiConsole.MarkupLine($"[bold red]{ex.Message}[/]");
                }
                break;

            case "help":
            default:
                if(args.Length > 1 && args[1] == "--arch")
                {
                    ShowAvailableArchitectures();
                }
                else
                {
                    ShowHelp();
                }

                break;
        }

        // Mostra os comandos disponíveis
        static void ShowHelp()
        {
            AnsiConsole.MarkupLine("[yellow]Available commands:[/]");
            AnsiConsole.MarkupLine("- [blue]init[/] [green]architecture[/]");
            AnsiConsole.MarkupLine("- [blue]help[/] [[--arch]]");
        }

        // Mostra as arquiteturas disponíveis
        static void ShowAvailableArchitectures()
        {
            var architectures = new[] { "clean", "ddd", "microservice" }; 
            AnsiConsole.MarkupLine("[yellow]Available architectures:[/]");
            foreach (var arch in architectures)
            {
                AnsiConsole.MarkupLine($"- [green]{arch}[/]");
            }
        }
    }
}
