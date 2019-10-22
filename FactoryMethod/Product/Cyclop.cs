using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product
{
    public class Cyclop : IMob
    {
        public int HP { get; set; }
        public int DefencePoints { get; set; }
        public void Attack()
        {
            Console.WriteLine("Cyclops just stares at you: 0 atk");
        }

        public void Seek()
        {
            Console.WriteLine("Looking for the enemy using the eye");
        }
    }
}
