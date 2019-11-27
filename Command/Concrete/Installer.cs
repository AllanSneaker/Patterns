using Command.Abstractions;
using System;

namespace Command.Concrete
{
    public class Installer
    {
        private readonly InstallerCommand _installerCommand;

        public Installer(InstallerCommand installerCommand)
        {
            _installerCommand = installerCommand;
        }

        public void Install()
        {
            try
            {
                Console.WriteLine("Installing process...\n");
                _installerCommand.Execute();
            }
            catch (Exception)
            {
                Console.WriteLine("Rolling back process...\n");
                _installerCommand.Rollback();
            }
        }
    }
}
