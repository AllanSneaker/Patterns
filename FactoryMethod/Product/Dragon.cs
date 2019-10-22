using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product
{
    public class Dragon : IMob
    {
        public int HP { get; set; }
        public int AttackPoints { get; set; }
        public int DefencePoints { get; set; }

        public void Attack()
        {
            Console.WriteLine($"Dragon attacks using fire: {AttackPoints} atk");
        }

        public void Seek()
        {
            Console.WriteLine("Looking for the enemy using the wings");
        }
    }
}
