using Composite.Abstractions;
using System.Collections.Generic;

namespace Composite.FileServices
{
    public abstract class FileComposite : File
    {
        private ICollection<File> _files;

        public FileComposite(string name)
            : base(name)
        {
            _files = new List<File>();
        }

        public override void Add(File file)
        {
            _files.Add(file);
        }

        public override string ToString()
        {
            string output = string.Format($"{new string('-', Nesting)} {Name} \n");

            foreach (var file in _files)
            {
                file.Nesting += Nesting + 2;
                output = string.Concat(output, file);
            }

            Nesting = 0;
            return output;
        }
    }
}
