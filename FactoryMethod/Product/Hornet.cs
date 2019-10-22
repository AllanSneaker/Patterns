using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product
{
    public class Hornet : IMob
    {
        public Debuffs Debuff { get; set; }

        public int HP { get; set; }
        public int AttackPoints { get; set; }

        public Hornet(Debuffs debuffs)
        {
            Debuff = debuffs;
        }

        public void Attack()
        {
            Console.WriteLine($"Hornet sting you with {AttackPoints} and gives you {Debuff.ToString()}!");
        }

        public void Seek()
        {
            Console.WriteLine("Hornet flies toward you, preparing guant sting!");
        }
    }
}
