using System;
namespace Task2
{
	public abstract class Animal: Alive
	{
        public string GetIndividual()
        {
            return "Individual: " + this.GetType().ToString();
        }

        public override string GetSpecies()
        {
            return "Species: " + nameof(Animal);
        }
    }
}

