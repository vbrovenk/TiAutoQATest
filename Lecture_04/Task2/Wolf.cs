using System;
namespace Task2
{
	public class Wolf: Animal, Carnivore
	{

        public void Eat(Animal animal)
        {
            Console.WriteLine("Wolf eats {0}", animal.GetType());
        }
    }
}

