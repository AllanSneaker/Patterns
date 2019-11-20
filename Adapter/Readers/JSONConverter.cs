using Adapter.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Adapter.Readers
{
    public class JSONConverter
    {
        private IEnumerable<Manufacturer> _manufacturers;

        public JSONConverter(IEnumerable<Manufacturer> manufacturers)
        {
            _manufacturers = manufacturers;
        }

        public void ConvertToJson()
        {
            var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);

            Console.WriteLine("\nPrinting JSON List");
            Console.WriteLine(jsonManufacturers);
        }
    }
}
