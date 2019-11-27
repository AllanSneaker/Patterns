using Command.Abstractions;
using System.Collections.Generic;

namespace Command.Concrete
{
    public class TransanctionInstallerCommand : InstallerCommand
    {
        private readonly List<InstallerCommand> _tasks;
        private Stack<InstallerCommand> _executedTasks;

        public TransanctionInstallerCommand(List<InstallerCommand> tasks)
        {
            _tasks = tasks;
        }

        public override void Execute()
        {
            _executedTasks = new Stack<InstallerCommand>();

            foreach (var task in _tasks)
            {
                _executedTasks.Push(task);
                task.Execute();
            }
            _executedTasks.Clear();
        }

        public override void Rollback()
        {
            while (_executedTasks.Count > 0)
            {
                _executedTasks.Pop().Rollback();
            }
        }
    }
}
