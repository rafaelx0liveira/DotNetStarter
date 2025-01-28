namespace DotNetStarter.CLI.Execute.Command;

public class HelpCommand
{
    public void Execute()
    {
        AnsiConsole.MarkupLine("[yellow]Available commands:[/]");
        AnsiConsole.MarkupLine("- [blue]init[/] [green]architecture[/]. Ex.: [yellow]dotnetstarter[/] [blue]init[/] [green]CleanArchitecture[/]");
        AnsiConsole.MarkupLine("- [blue]help[/]");
        AnsiConsole.MarkupLine("- [blue]list[/]");
    }
}
