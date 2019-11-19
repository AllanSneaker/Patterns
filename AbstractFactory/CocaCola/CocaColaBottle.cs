using System;
using AbstractFactory.Abstractions;

namespace AbstractFactory.CocaCola
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine($"{this} interact with {water}");
        }

        public override void Interact(AbstractCap cap)
        {
            Console.WriteLine($"{this} interact with {cap}");
        }

        public override void Interact(AbstractLabel label)
        {
            Console.WriteLine($"{this} interact with {label}");
        }
    }
}
