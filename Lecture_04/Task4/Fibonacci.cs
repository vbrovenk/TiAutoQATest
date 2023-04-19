using System;

namespace Task4
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

        private int RecursiveFib(int n)
        {
            if (n <= 1)
                return 1;
            else
                return RecursiveFib(n - 1) + RecursiveFib(n - 2);
        }

        public void CalculateRowFibonacci()
        {
            int currentNbr = 0;
            int i = 0;

            Console.Write("=> ");
            while (currentNbr <= endNumber)
            {
                Console.Write("{0} ", currentNbr);
                i += 1;
                currentNbr = RecursiveFib(i);
            }
        }
    }
}
