using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class CorruptionLandSpawner : ISpawner
    {
        public IMob SpawnMob(int level)
        {
            IMob corruptedDragon = new Dragon
            {
                HP = level * 50,
                AttackPoints = level * 30,
                DefencePoints = level
            };

            return corruptedDragon;
        }
    }
}
