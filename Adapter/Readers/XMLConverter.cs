using Adapter.Models;
using System;
using System.Linq;
using System.Xml.Linq;

namespace Adapter.Readers
{
    public class XMLConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Manufacturers");
            var xAttributes = Initializer.GetData()
                .Select(x => new XElement("Manufacturer",
                                   new XAttribute("Name", x.Name),
                                   new XAttribute("City", x.City),
                                   new XAttribute("Year", x.Year)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}
