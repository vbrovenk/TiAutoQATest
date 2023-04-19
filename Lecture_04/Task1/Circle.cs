using System;
namespace Task1
{
	public class Circle : Shape
	{
		private double radius;

		public Circle(double r)
		{
			this.radius = r;
		}

        public override double CalculateArea()
        {
			return Math.PI * (radius * radius);
        }
    }
}

