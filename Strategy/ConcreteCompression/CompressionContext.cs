using Strategy.AbstractCompression;

namespace Strategy.ConcreteCompression
{
    public class CompressionContext
    {
        private ICompression _compression;

        public CompressionContext(ICompression compression)
        {
            _compression = compression;
        }

        public void SetStrategy(ICompression compression)
        {
            _compression = compression;
        }

        public void CreateArchive(string compressedArchiveFiledName)
        {
            _compression.CompressFolder(compressedArchiveFiledName);
        }
    }
}
