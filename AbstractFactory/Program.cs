using AbstractFactory.CocaCola;

namespace AbstractFactory
{
    class Program
    {

        /// <summary>
        /// if we need another factory for example PepsiColaFactory.
        /// Production may be similar.</summary>
        static void Main(string[] args)
        {
            Client client;
            client = new Client(new CocaColaFactory());
            client.RunProcess();
        }
    }
}
