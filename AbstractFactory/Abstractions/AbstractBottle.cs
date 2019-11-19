namespace AbstractFactory.Abstractions
{
    public abstract class AbstractBottle
    {
        /// <summary>
        /// A little bit of state. May be as a model. 
        /// </summary>
        public float Size { get; set; }
        public string Type { get; set; } //plastic or glass
        public string Shape { get; set; }

        public abstract void Interact(AbstractWater water);
        public abstract void Interact(AbstractCap cap);
        public abstract void Interact(AbstractLabel label);
    }
}