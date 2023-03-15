using System;

namespace TiAutoQATest
{
    class Point
    {
        public double x;
        public double y;
        public string name;
    }

    class Triangle
    {
        private Point[] points = new Point[3];
        private int pointName = 65; // first capital letter in ASCII -> A
        private double[] lengthSides = new double[3];
        private double perimeter = 0;

        public void initializePoints()
        {
            for (int i = 0; i < 3; i++)
            {
                Point newPoint = new Point();
                newPoint.name = ((char)(pointName + i)).ToString();
                inputAndParse(ref newPoint.x, 'x', newPoint.name);
                inputAndParse(ref newPoint.y, 'y', newPoint.name);
                points[i] = newPoint;
            }
        }

        private void inputAndParse(ref double val, char coord, string pointName)
        {
            string inputVal = "";

            while (true)
            {
                Console.WriteLine("Enter coordinate {0} of dot {1}:", coord, pointName);
                inputVal = Console.ReadLine();
                if (Double.TryParse(inputVal, out val))
                    break;
                else
                {
                    Console.WriteLine("Unable to parse '{0}'.", inputVal);
                    Console.WriteLine("Repeat your input, please.");
                }
                    
            }
        }

        private double calculateSide(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.x - point1.x, 2) + Math.Pow(point2.y - point1.y, 2));
        }

        public void findLengthSides()
        {
            double tempLength = 0;

            for (int i = 0; i < 3; i++)
            {
                if (i + 1 == 3)
                {
                    tempLength = calculateSide(points[0], points[i]);
                    Console.WriteLine("Length of {0} is: {1}", points[0].name + points[1].name, tempLength);
                } else
                {
                    tempLength = calculateSide(points[i], points[i + 1]);
                    Console.WriteLine("Length of {0} is: {1}", points[i].name + points[i + 1].name, tempLength);
                }
                lengthSides[i] = tempLength;
                
            }
        }

        public bool checkIfEquilateralTriangle()
        {
            if (lengthSides[0] == lengthSides[1] && 
                lengthSides[1] == lengthSides[2] &&
                lengthSides[0] == lengthSides[2])
                return true;
           else
                return false; 
        }

        public bool checkIfRightTriangle()
        {
            double delta = 0.1;
            
            for (int i = 0; i < 3; i++)
            {
                double sumCathetus = Math.Pow(lengthSides[(i + 1) % 3], 2) + Math.Pow(lengthSides[(i + 2) % 3], 2);
                if (Math.Abs(Math.Pow(lengthSides[i], 2) - sumCathetus) <= delta) 
                {
                    return true;
                }
            }

            return false;
        } 

        public bool checkIfIsoscelesTriangle()
        {
            if (lengthSides[0] == lengthSides[1] ||
                lengthSides[1] == lengthSides[2] ||
                lengthSides[0] == lengthSides[2])
                return true;
            else
                return false;
        }

        public void determinePerimeter()
        {
            foreach (double side in lengthSides)
            {
                perimeter += side;
            }

            Console.WriteLine("Perimeter: {0}", perimeter);
        }

        public void findEvenNumbers()
        {
            Console.WriteLine("Numbers in range from 0 to triangle perimeter: ");
            for (int i = 0; i < perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void printInfoPoints()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("point {0}: X = {1} | Y = {2}", points[i].name, points[i].x, points[i].y);
            }
        }
    }

    class Program
    {
        public static void printInfo(bool val, string checkType)
        {
            if (val)
                Console.WriteLine("Triangle IS '{0}'", checkType);
            else
                Console.WriteLine("Triangle IS NOT '{0}'", checkType);
        }
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            
            triangle.initializePoints();
            Console.WriteLine();

            triangle.findLengthSides();
            Console.WriteLine();

            printInfo(triangle.checkIfEquilateralTriangle(), "Equilateral");

            printInfo(triangle.checkIfIsoscelesTriangle(), "Isosceles");

            printInfo(triangle.checkIfRightTriangle(), "Right");

            Console.WriteLine();
            triangle.determinePerimeter();

            triangle.findEvenNumbers();

            Console.ReadKey();
        }
    }
}
