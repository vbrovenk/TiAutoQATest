using System;
using System.Drawing;

namespace Task6
{
	public class SimpleLightString: Lightstring
	{
		public SimpleLightString(int countBulbs)
		{
            bulbs = new Bulb[countBulbs];

            for (int i = 0; i < bulbs.Length; i++)
            {
                bulbs[i] = new Bulb();
            }
        }

        public override void CurrentState()
        {
            Console.WriteLine("==== SIMPLE LIGHTSTRING ====");

            base.PrintBulbState();
        }

    }
}

