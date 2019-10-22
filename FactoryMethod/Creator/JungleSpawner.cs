using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class JungleSpawner : ISpawner
    {
        public Debuffs Debuff { get; set; }
        public JungleSpawner(Debuffs debuffs)
        {
            Debuff = debuffs;
        }
        public IMob SpawnMob(int level)
        {
            IMob jungleHornet = new Hornet(Debuff) {
                HP = 25 * level,
                AttackPoints = 5 * level
            };

            return jungleHornet;
        }
    }
}
