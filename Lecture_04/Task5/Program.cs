// Implement the Polynomial class.
// The coefficients of the polynomial are set through the constructor.
// Implement the ToString() method in this class, which returns a string representation of the class in the form of
// -3 + 4x^2 + 5x^5 – 12x^7
// Implement overloading of binary operators +, -, *


using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polynomial polynom1 = new Polynomial(-3, 4, 5, -12);
            Console.WriteLine(polynom1.ToString());

            Polynomial polynom2 = new Polynomial(2, -5, 6, 9);
            Console.WriteLine(polynom2.ToString());

            Console.WriteLine("Sum of polynoms: ");
            Polynomial polynom3 = polynom1 + polynom2;
            Console.WriteLine(polynom3.ToString());

            Console.WriteLine("Diff of polynoms: ");
            Polynomial polynom4 = polynom1 - polynom2;
            Console.WriteLine(polynom4.ToString());

            Console.WriteLine("Multiplication of polynoms: ");
            Polynomial polynom5 = polynom1 * polynom2;
            Console.WriteLine(polynom5.ToString());

            Console.ReadKey();
        }
    }
}

