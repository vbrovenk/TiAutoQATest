using System;
using System.Drawing;

namespace Task6
{
    public enum Color
    {
        red,
        yellow,
        blue,
        green
    }

    public class ColoredBulb: Bulb
	{
		private Color colorBulb;

		public ColoredBulb(Color color)
		{
			this.colorBulb = color;
		}

		public string getColorName()
		{
            return Enum.GetName(typeof(Color), colorBulb);
        }
	}
}

