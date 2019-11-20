using Adapter.FormatAdapter;
using Adapter.Readers;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlConverter = new XMLConverter();
            var adapter = new XMLtoJSON(xmlConverter);
            adapter.ConvertXMLtoJSON();
        }
    }
}
