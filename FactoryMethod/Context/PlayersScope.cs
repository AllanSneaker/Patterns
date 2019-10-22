using System;
using System.Collections.Generic;
using System.Text;

using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.Logistics
{
    public class PlayersScope
    {
        private int CurrentLevel { get; set; }
        public ISpawner MobSpawner { get; set; }
        public List<IMob> Mobs { get; }

        public PlayersScope(int level)
        {
            CurrentLevel = level;
            Mobs = new List<IMob>();
        }

        public void OnCycle()
        {
            if (Mobs.Count == 0)
                Mobs.Add(MobSpawner.SpawnMob(CurrentLevel));
        }

        public void DefenceFromMobs()
        {
            foreach (var mob in Mobs)
            {
                mob.Seek();
                mob.Attack();
            }
        }
    }
}
