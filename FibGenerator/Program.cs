using System;
using System.CommandLine;
using System.IO;
using System.Windows.Input;
using FibGenerator.CommandHandlers.FibCommandHandler;
using FibGenerator.CommandHandlers.HelpCommandHandler;
using FibGenerator.Commands;

namespace FibGenerator;

class Program
{
    static void Main(string[] args)
    {
        ServiceResolver.Initialize();
        var helpCommand = new Command("help");
        var fibCommand = new Command("fib");
        helpCommand.AddAlias("Help");
        fibCommand.AddAlias("Fib");
        var fibPlacesArgument = new Argument<int>();
        fibCommand.AddArgument(fibPlacesArgument);
        var rootCommand = new RootCommand
        {
            helpCommand,
            fibCommand
        };

        helpCommand.SetHandler(() =>
        {
            var helpHandler = ServiceResolver.Resolve<IHelpCommandHandler>();
            var helpCommand = new HelpCommand(helpHandler);
            
        });

        fibCommand.SetHandler((placesArg) =>
        {
            var fibHandler = ServiceResolver.Resolve<IFibCommandHandler>();
            var fibCommand = new FibCommand(placesArg, fibHandler);
            fibCommand.Execute();
        },
    fibPlacesArgument);

        rootCommand.Invoke(args);

        ServiceResolver.DisposeContainer();
    }
}
