using System;
namespace Task2
{
	public class Rabbit: Animal, Herbivore
	{
        public void Eat(Herbal herbal)
        {
            Console.WriteLine("Rabbit eats {0}", herbal.GetType());
        }
    }
}

