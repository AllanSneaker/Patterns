using Strategy.AbstractCompression;
using System;

namespace Strategy.ConcreteCompression
{
    public class RARCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFiledName)
        {
            Console.WriteLine($"Folder is compressed using RAR approach: " +
                $"{compressedArchiveFiledName}.rar file is created"); 
        }
    }
}
