using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class DungeonSpawner : ISpawner
    {
        public int Difficulty { get; set; }

        public DungeonSpawner(int difficulty)
        {
            Difficulty = difficulty;
        }

        public IMob SpawnMob(int level)
        {
            IMob dungeonCyclop = new Cyclop {
                HP = level * 30 * Difficulty,
                DefencePoints = level * 2
            };

            return dungeonCyclop;
        }
    }
}
