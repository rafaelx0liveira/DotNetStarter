using DotNetStarter.CLI.Execute.Command;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.CLI.Execute
{
    public class CommandExecutor
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandExecutor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Execute(string[] args) {
            var command = args.Length > 0 ? args[0].ToLower() : "help";

            switch (command) 
            {
                case "init":
                    var initCommand = _serviceProvider.GetRequiredService<InitCommand>();
                    initCommand.Execute(args);
                    break;

                case "list":
                    var listCommand = _serviceProvider.GetRequiredService<ListCommand>();
                    listCommand.Execute(args);
                    break;

                case "help":
                default:
                    var helpCommand = _serviceProvider.GetRequiredService<HelpCommand>();
                    helpCommand.Execute();
                    break;
            }
        }
    }
}
