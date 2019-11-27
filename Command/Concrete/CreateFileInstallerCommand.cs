using Command.Abstractions;
using System;
using System.IO;

namespace Command.Concrete
{
    public class CreateFileInstallerCommand : InstallerCommand
    {
        private readonly string _filePath;

        public CreateFileInstallerCommand(string filePath)
        {
            _filePath = filePath;
        }
        public override void Execute()
        {
            using (File.Create(_filePath)) { }

            Console.WriteLine($"File Created: {_filePath}");
        }

        public override void Rollback()
        {
            File.Delete(_filePath);

            Console.WriteLine($"File Deleted {_filePath}");
        }
    }
}
