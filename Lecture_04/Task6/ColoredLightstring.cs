using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task6
{
	public class ColoredLightstring: Lightstring
	{
		private int serialNumber;
        private Color color;

		public ColoredLightstring(int serialNumber, int countBulbs)
		{
            if (serialNumber <= 0)
                serialNumber = 1;
            else
                this.serialNumber = serialNumber;

            bulbs = new ColoredBulb[countBulbs];
            color = (Color)((serialNumber - 1) % Enum.GetNames(typeof(Color)).Length);

            for (int i = 0; i < bulbs.Length; i++)
            {
                bulbs[i] = new ColoredBulb(color);
            }
        }

        public override void CurrentState()
        { 
            Console.WriteLine("==== COLORED LIGHTSTRING ====");
            Console.WriteLine("Current color: {0}", color.ToString());

            base.PrintBulbState();
        }
    }
}

