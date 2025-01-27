using DotNetStarter.Core.Services;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.CLI.Execute.Command
{
    public class InitCommand
    {
        private readonly ProjectGenerator _projectGenerator;

        public InitCommand(ProjectGenerator projectGenerator)
        {
            _projectGenerator = projectGenerator;
        }

        public void Execute(string[] args)
        {
            var architecture = args.Length > 1 ? args[1] : "CleanArchitecture";
            var projectName = AnsiConsole.Ask<string>("Project name [[default: MyProject]]:", "MyProject");
            var outputPath = AnsiConsole.Ask<string>("Output directory [[default: current]]:", ".");

            try
            {
                _projectGenerator.CreateProject(projectName, architecture, outputPath);
                AnsiConsole.Markup("[green]Project created successfully![/]");
            }
            catch (Exception ex)
            {
                AnsiConsole.MarkupLine($"[bold red]{ex.Message}[/]");
            }
        }
    }
}
