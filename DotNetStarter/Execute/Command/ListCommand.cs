using DotNetStarter.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.CLI.Execute.Command
{
    public class ListCommand
    {
        private readonly IServiceProvider _serviceProvider;
        public ListCommand(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Execute(string[] args)
        {
            // Resolve todas as factories registradas
            var factories = _serviceProvider.GetServices<IArchitectureFactory>();

            AnsiConsole.MarkupLine("[yellow]Available architectures:[/]");
            foreach (var factory in factories)
            {
                var architectureName = factory.GetType().Name.Replace("Factory", "");

                if (architectureName.StartsWith("Clean"))
                {
                    AnsiConsole.MarkupLine($"- [green]{architectureName}[/] [yellow](DEFAULT)[/]");
                } else
                {
                    AnsiConsole.MarkupLine($"- [green]{architectureName}[/]");
                }
            }
        }
    }
}
