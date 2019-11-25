using ChainOfResponsibility.Processes;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadProcess downloadProcess = new DownloadProcess();
            ExtractProcess extractProcess = new ExtractProcess();
            LoadProcess loadProcess = new LoadProcess();

            downloadProcess.SetNextProcess(extractProcess);
            extractProcess.SetNextProcess(loadProcess);

            downloadProcess.Process();
            
        }
    }
}
