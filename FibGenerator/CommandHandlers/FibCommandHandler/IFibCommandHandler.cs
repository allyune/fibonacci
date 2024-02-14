using System;
using FibGenerator.CommandHandlers.FibGenerator;

namespace FibGenerator.CommandHandlers.FibCommandHandler
{
	public interface IFibCommandHandler
	{
		public void PrintFibonacciNumbers(int places);
		public void SetFibGenerator(IFibGenerator generator);
	}
}

