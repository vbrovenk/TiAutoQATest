using System;
namespace Task2
{
	public class Bear: Animal, Carnivore, Herbivore
	{
        public void Eat(Herbal herbal)
        {
            Console.WriteLine("Bear eats {0}", herbal.GetType());
        }

        public void Eat(Animal animal)
        {
            Console.WriteLine("Bear eats {0}", animal.GetType());
        }
    }
}

