using System;
namespace FibGenerator.CommandHandlers.HelpCommandHandler
{
	public class HelpCommandHandler : IHelpCommandHandler
    { 
		public HelpCommandHandler()
		{
		}

        public void PrintHelp()
        {
            Console.WriteLine("Printing app help...");
        }
    }
}

