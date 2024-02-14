using System;
using FibGenerator.CommandHandlers.FibCommandHandler;

namespace FibGenerator.Commands
{
	public class FibCommand : ICommand
	{
        private readonly int _places;
        private readonly IFibCommandHandler _fibCommandHandler;

        public FibCommand(int places, IFibCommandHandler fibCommandHandler)
		{
            if (places < 0)
                throw new ArgumentOutOfRangeException(nameof(places), "Places cannot be negative.");
            _places = places;
            _fibCommandHandler = fibCommandHandler;
        }

        public void Execute()
        {
            _fibCommandHandler.PrintFibonacciNumbers(_places);
        }
    }
}