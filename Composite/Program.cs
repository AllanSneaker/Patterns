using Composite.FileServices;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new FolderFile("Documents");
            var pdfFile = new SystemFile("Document.pdf");
            var docFile = new SystemFile("Document.doc");
            var pptxFile = new SystemFile("Presentation.pptx");

            documents.Add(pdfFile);
            documents.Add(docFile);
            documents.Add(pptxFile);

            var rootFolder = new FolderFile("Data");
            rootFolder.Add(documents);

            Console.WriteLine(rootFolder);
            Console.WriteLine(documents);

        }
    }
}
