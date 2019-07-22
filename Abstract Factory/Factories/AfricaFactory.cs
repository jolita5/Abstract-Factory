using Abstract_Factory.Animals.Herbivores;
using Abstract_Factory.Animals.Carnivores;
using Abstract_Factory.AbstractClasses;

namespace Abstract_Factory.Factories
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
