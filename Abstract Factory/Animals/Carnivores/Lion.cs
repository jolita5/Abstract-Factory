using Abstract_Factory.AbstractClasses;
using System;


namespace Abstract_Factory.Animals.Carnivores
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eat " + h.GetType().Name);
        }
    }
}
