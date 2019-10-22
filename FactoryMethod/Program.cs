using FactoryMethod.Creator;
using FactoryMethod.Logistics;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayersScope sc = new PlayersScope(3);

            // On dungeon level

            sc.MobSpawner = new JungleSpawner(Product.Debuffs.Poisoning);

            sc.OnCycle();
            sc.DefenceFromMobs();
        }
    }
}
