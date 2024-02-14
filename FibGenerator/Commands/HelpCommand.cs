using System;
using FibGenerator.CommandHandlers.HelpCommandHandler;

namespace FibGenerator.Commands
{
	public class HelpCommand : ICommand
	{
        private readonly IHelpCommandHandler _helpCommandHandler;

        public HelpCommand(IHelpCommandHandler helpCommandHandler)
        {
            _helpCommandHandler = helpCommandHandler;
        }

        public void Execute()
        {
            _helpCommandHandler.PrintHelp();
        }
    }
}

