using Adapter.Models;
using Adapter.Readers;
using System;
using System.Linq;

namespace Adapter.FormatAdapter
{
    public class XMLtoJSON : IXMLtoJSON
    {
        private readonly XMLConverter _xMLConverter;

        public XMLtoJSON(XMLConverter xMLConverter)
        {
            _xMLConverter = xMLConverter;
        }

        public void ConvertXMLtoJSON()
        {
            var manufacturers = _xMLConverter.GetXML()
                .Element("Manufacturers")
                .Elements("Manufacturer")
                .Select(j => new Manufacturer
                {
                    Name = j.Attribute("Name").Value,
                    City = j.Attribute("City").Value,
                    Year = Convert.ToInt32(j.Attribute("Year").Value)
                });

            new JSONConverter(manufacturers).ConvertToJson();
        }
    }
}
