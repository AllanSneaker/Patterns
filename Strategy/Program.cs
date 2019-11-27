using Strategy.ConcreteCompression;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var compressionContext = new CompressionContext(new RARCompression());
            compressionContext.CreateArchive("MyFolder");

            compressionContext.SetStrategy(new ZIPCompression());
            compressionContext.CreateArchive("MyFolder");
        }
    }
}
