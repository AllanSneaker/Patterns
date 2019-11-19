using AbstractFactory.Abstractions;

namespace AbstractFactory.CocaCola
{
    class CocaColaFactory : Abstractions.AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractCap CreateCap()
        {
            return new CocaColaCap();
        }

        public override AbstractLabel CreateLabel()
        {
            return new CocaColaLabel();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }
    }
}
