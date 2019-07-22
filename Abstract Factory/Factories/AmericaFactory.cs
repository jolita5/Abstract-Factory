using Abstract_Factory.AbstractClasses;
using Abstract_Factory.Animals.Carnivores;
using Abstract_Factory.Animals.Herbivores;

namespace Abstract_Factory.Factories
{
    class AmericaFactory : ContinentFactory

    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
