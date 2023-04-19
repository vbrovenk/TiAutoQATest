using System;

namespace Task3
{
	public class Fibonacci
	{
		private int endNumber;

		public void InputNumber()
		{
			Console.WriteLine("Input end number: ");
            while (!int.TryParse(Console.ReadLine(), out endNumber) || endNumber < 0)
            {
                Console.WriteLine("Invalid data! Try again: ");
            }
        }

		public void CalculateRowFibonacci()
		{
			int currentNbr = 0;
			int nextNbr = 1;
			int temp = 0;

            Console.Write("=> {0} ", currentNbr);
            while (endNumber >= nextNbr)
			{
				Console.Write("{0} ", nextNbr);
				temp = nextNbr;
				nextNbr = currentNbr + nextNbr;
				currentNbr = temp;
			}
		}
	}
}
