using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.CLI.Execute.Command
{
    public class HelpCommand
    {
        public void Execute()
        {
            AnsiConsole.MarkupLine("[yellow]Available commands:[/]");
            AnsiConsole.MarkupLine("- [blue]init[/] [green]architecture[/]");
            AnsiConsole.MarkupLine("- [blue]help[/]");
            AnsiConsole.MarkupLine("- [blue]list[/]");
        }
    }
}
