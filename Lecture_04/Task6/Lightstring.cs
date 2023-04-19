using System;
namespace Task6
{
	public abstract class Lightstring
	{
		public abstract void CurrentState();
        protected Bulb[] bulbs;

        public bool IsEvenMinute()
        {
            if (DateTime.Now.Minute % 2 == 0)
                return true;
            else
                return false;
        }

        public void PrintBulbState()
        {
            bool flagEvenMinute = IsEvenMinute();

            Console.Write("ColoredLisghtstring: -");

            for (int i = 0; i < bulbs.Length; i++)
            {
                if ((flagEvenMinute == true && (i + 1) % 2 == 0) ||
                    (flagEvenMinute == false && (i + 1) % 2 != 0))
                {
                    Console.Write("({0})ON-", i + 1);
                }
                else
                    Console.Write("({0})OFF-", i + 1);
            }
            Console.WriteLine();
        }
    }
}

