using System;
namespace Task1
{
	public class Triangle : Shape
	{
		private double baseSide;
		private double height;

		public Triangle(double b, double h)
		{
			this.baseSide = b;
			this.height = h;
		}

        public override double CalculateArea()
        {
			return 1 / 2.0 * baseSide * height;
        }

    }
}

