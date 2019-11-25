
namespace Composite.Abstractions
{
    public abstract class File
    {
        public string Name { get; private set; }
        public int Nesting { get; set; }

        public File(string name)
        {
            Name = name;
        }

        public abstract void Add(File file);
    }
}
