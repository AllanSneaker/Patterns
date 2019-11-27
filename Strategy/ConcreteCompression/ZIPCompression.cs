using Strategy.AbstractCompression;
using System;

namespace Strategy.ConcreteCompression
{
    public class ZIPCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFiledName)
        {
            Console.WriteLine($"Folder is compressed using ZIP approach: " +
                $"{compressedArchiveFiledName}.zip file is created");
        }
    }
}
