using Command.Abstractions;
using Command.Concrete;
using System.Collections.Generic;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var transanctions = new TransanctionInstallerCommand(new List<InstallerCommand>
            { new CreateFileInstallerCommand(@"D:\test.txt"),
              new AppendTextInstallerCommand(@"D:\test.txt", "some text")
            });

            var installer = new Installer(transanctions);
            installer.Install();
        }
    }
}
