using Command.Abstractions;
using System;
using System.IO;

namespace Command.Concrete
{
    public class AppendTextInstallerCommand : InstallerCommand
    {
        private readonly string _filePath;
        private string _text;

        public AppendTextInstallerCommand(string filePath, string text)
        {
            _filePath = filePath;
            _text = text;
        }

        public override void Execute()
        {
            using (StreamWriter writer = File.AppendText(_filePath))
            {
                writer.WriteLine(_text);

                Console.WriteLine($"Appended {_text} to file {_filePath}\n");
            }
        }

        public override void Rollback()
        {
            var fileText = File.ReadAllText(_text);

            if (fileText.EndsWith(_text + "\r\n"))
            {
                File.WriteAllText(_filePath, fileText.Substring(0, fileText.Length - _text.Length - 2));
                Console.WriteLine($"Removed {_text} from {_filePath}\n");
            }
        }
    }
}
