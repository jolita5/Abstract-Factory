

namespace Abstract_Factory.AbstractClasses
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
