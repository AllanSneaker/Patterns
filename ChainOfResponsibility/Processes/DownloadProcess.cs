using ChainOfResponsibility.Abstract;
using System;

namespace ChainOfResponsibility.Processes
{
    class DownloadProcess : AbstractProcess
    {
        public override void Process()
        {
            Console.WriteLine(new string('_', 10) + "Download Process" + new string('_', 10));

            if (_next != null)
            {
                _next.Process();
            }
        }
    }
}
