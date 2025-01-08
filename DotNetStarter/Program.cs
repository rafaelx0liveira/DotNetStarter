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
                var projectName = AnsiConsole.Ask<string>("What is the [green]project name[/]?");
                var outputPath = AnsiConsole.Ask<string>("Output directory [default: current]:", ".");

                //ProjectGenerator.CreateProject(architecture, projectName, outputPath);
                AnsiConsole.Markup("[green]Project created successfully![/]");
                break;


            case "help":
            default:
                AnsiConsole.Markup("[yellow]Available commands:[/]");
                AnsiConsole.Markup("\n- init [architecture] [options]");
                break;

        }
    }
}
