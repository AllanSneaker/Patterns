using Composite.Abstractions;

namespace Composite.FileServices
{
    public sealed  class SystemFile : File
    {
        public SystemFile(string name) : base(name) { }
        public override void Add(File file) { }

        public override string ToString()
        {
            string output = string.Format($"{new string('-', Nesting)} {Name} \n");
            Nesting = 0;

            return output;
        }
    }
}
