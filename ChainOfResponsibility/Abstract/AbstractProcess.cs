
namespace ChainOfResponsibility.Abstract
{
    abstract class AbstractProcess
    {
        protected AbstractProcess _next;
        public abstract void Process();
        public void SetNextProcess(AbstractProcess process)
        {
            _next = process;
        }
    }
}
