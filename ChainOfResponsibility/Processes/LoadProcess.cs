using ChainOfResponsibility.Abstract;
using System;

namespace ChainOfResponsibility.Processes
{
    class LoadProcess : AbstractProcess
    {
        public override void Process()
        {
            Console.WriteLine(new string('_', 10) + "Load Process" + new string('_', 10));

            if (_next != null)
            {
                _next.Process();
            }
        }
    }
}
