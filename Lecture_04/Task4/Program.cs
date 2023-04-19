// Implement an application that accepts a natural number from the console and
// prints all Fibonacci numbers up to the entered number to the console.
// Implement the task using a recursion.

using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();
            fib.InputNumber();
            fib.CalculateRowFibonacci();

            Console.ReadKey();
        }
    }
}