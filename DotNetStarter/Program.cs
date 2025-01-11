using DotNetStarter.Core.Architectures;
using DotNetStarter.Core.ProjectGenerator;
using DotNetStarter.Templates;
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

            case "list":
                var arch = args.Length > 1 && args[1].StartsWith("--arch=")
                    ? args[1].Substring("--arch=".Length) : null;

                if (arch == null)
                {
                    AnsiConsole.MarkupLine("[bold red]Please specify an architecture using --arch=[architecture][/].");
                }
                else
                {
                    ListStructure(arch);
                }

                break;  
        }

        // List the availables commands
        static void ShowHelp()
        {
            AnsiConsole.MarkupLine("[yellow]Available commands:[/]");
            AnsiConsole.MarkupLine("- [blue]init[/] [green]architecture[/]");
            AnsiConsole.MarkupLine("- [blue]help[/] [[--arch]]");
        }

        // List availables architectures
        static void ShowAvailableArchitectures()
        {
            AnsiConsole.MarkupLine("[yellow]Available architectures:[/]");
            foreach (var arch in Architectures.AvailableArchitectures) 
            {
                AnsiConsole.MarkupLine($"- [green]{arch}[/]");
            }
        }

        // List the structure of architecture
        static void ListStructure(string architecture)
        {
            try
            {
                var templatePath = TemplateLoader.GetTemplatePath(architecture);

                if (!Directory.Exists(templatePath))
                {
                    throw new DirectoryNotFoundException($"Template '{architecture}' not found at '{templatePath}'.");
                }

                AnsiConsole.MarkupLine($"[yellow]Directory structure for architecture '{architecture}':[/]");
                PrintDirectoryStructure(templatePath, 0);
            }
            catch (Exception ex)
            {
                AnsiConsole.MarkupLine($"[bold red]{ex.Message}[/]");
            }
        }

        static void PrintDirectoryStructure(string directory, int indentLevel)
        {
            var indent = new string(' ', indentLevel * 4);
            var dirName = Path.GetFileName(directory);
            AnsiConsole.MarkupLine($"{indent}[blue]{dirName}[/]/");

            foreach (var subDir in Directory.GetDirectories(directory))
            {
                PrintDirectoryStructure(subDir, indentLevel + 1);
            }
        }
    }
}
