// Create classes Square, Triangle, Circle, Shape. Define methods for calculating
// area and perimeter for them. Determine which of these classes can be abstract.


using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(4);
            Console.WriteLine("Sqare area = {0}", square1.CalculateArea());

            Triangle triangle1 = new Triangle(4, 2);
            Console.WriteLine("Triangle area = {0}", triangle1.CalculateArea());

            Circle circle1 = new Circle(12);
            Console.WriteLine("Circle area = {0}", circle1.CalculateArea());

            Console.ReadKey();
        }
    }
}
