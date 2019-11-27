
namespace Command.Abstractions
{
    public abstract class InstallerCommand
    {
        public abstract void Execute();
        public abstract void Rollback();
    }
}
