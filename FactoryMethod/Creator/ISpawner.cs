using System;
using System.Collections.Generic;
using System.Text;

using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public interface ISpawner
    {
        IMob SpawnMob(int level);
    }
}
