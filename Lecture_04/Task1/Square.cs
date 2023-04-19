using System;

namespace Task1
{
	public class Square : Shape
	{
		private double sideA;

		public Square(double a)
		{
			this.sideA = a;
		}

		public override double CalculateArea()
		{
			return sideA * sideA;
		}
	}
}

