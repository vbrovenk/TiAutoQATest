// Create and describe a hierarchy for the entities
// Animal, Herbal, Herbivore, Carnivore, Alive, Wolf (predator), Rabbit (herbivore),
// Bear (omnivore), Rose, Grass.
// - all living beings must have a method that returns the name of the species.
// - each item of an animal must have a method that returns the name of a particular individual.
// - animals can be omnivores
// - herbivores must have an Eat() method that takes a plant as a parameter
// - predators must have an Eat() method that takes an animal as a parameter

using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf1 = new Wolf();
            Rabbit rabbit1 = new Rabbit();
            Bear bear1 = new Bear();

            Rose rose1 = new Rose();
            Herbal grass1 = new Grass();

            Console.WriteLine(wolf1.GetSpecies());
            Console.WriteLine(wolf1.GetIndividual());
            wolf1.Eat(rabbit1);

            Console.WriteLine("==========================");
            
            Console.WriteLine(rabbit1.GetSpecies());
            Console.WriteLine(rabbit1.GetIndividual());
            rabbit1.Eat(grass1);

            Console.WriteLine("==========================");

            Console.WriteLine(bear1.GetSpecies());
            Console.WriteLine(bear1.GetIndividual());
            bear1.Eat(grass1);
            bear1.Eat(rose1);

            Console.ReadKey();
        }
    }
}
