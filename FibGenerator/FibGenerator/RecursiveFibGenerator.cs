using System;
using System.Linq;

namespace FibGenerator.CommandHandlers.FibGenerator
{
	public class RecursiveFibGenerator : IFibGenerator
	{
		public RecursiveFibGenerator()
		{
		}

        public List<int> GenerateFibonacciNumbers(int places)
        {
            return Enumerable.Range(0, places).Select(Fibonacci).ToList();
        }

        private int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}

