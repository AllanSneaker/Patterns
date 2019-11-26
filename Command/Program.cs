using Command.Concrete;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var createFile = new CreateFileInstallerCommand(@"D:\Test\test.txt");
            //var appendText = new AppendTextInstallerCommand(@"D:\Test\test.txt", "text");

            var installer = new Installer(createFile);
            installer.Install();

            //var installer2 = new Installer(appendText);
            //installer2.Install();
        }
    }
}
