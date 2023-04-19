using System;
namespace Task2
{
	public abstract class Herbal: Alive
	{
        public override string GetSpecies()
        {
            return "Species: " + nameof(Herbal);
        }
    }
}

