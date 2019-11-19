using AbstractFactory.Abstractions;

namespace AbstractFactory
{
    public class Client
    {
        private AbstractBottle _bottle;
        private AbstractWater _water;
        private AbstractCap _cap;
        private AbstractLabel _label;

        public Client(Abstractions.AbstractFactory factory)
        {
            _bottle = factory.CreateBottle();
            _water = factory.CreateWater();
            _cap = factory.CreateCap();
            _label = factory.CreateLabel();
        }

        public void RunProcess()
        {
            _bottle.Interact(_water);
            _bottle.Interact(_cap);
            _bottle.Interact(_label);
        }
        
    }
}
