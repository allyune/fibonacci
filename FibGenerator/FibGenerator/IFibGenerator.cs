using System;
namespace FibGenerator.CommandHandlers.FibGenerator
{
	public interface IFibGenerator
    {
        List<int> GenerateFibonacciNumbers(int places);
    }
}

