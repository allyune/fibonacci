using System;
using FibGenerator.CommandHandlers.FibGenerator;

namespace FibGenerator.CommandHandlers.FibCommandHandler
{
	public class FibCommandHandler : IFibCommandHandler
	{
		private IFibGenerator _fibGenerator;

		// default fib generator strategy
        public FibCommandHandler(IFibGenerator fibGenerator)
        {
			_fibGenerator = fibGenerator;
        }

        public void PrintFibonacciNumbers(int places)
		{
			List<int> fibNumbers = _fibGenerator.GenerateFibonacciNumbers(places);
			foreach(int num in fibNumbers)
			{
				Console.Write(num + " ");
			}
		}

        public void SetFibGenerator(IFibGenerator generator)
        {
			_fibGenerator = generator;
        }
    }
}

