
namespace AbstractFactory.Abstractions
{
    public abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractCap CreateCap();
        public abstract AbstractLabel CreateLabel();
    }
}
