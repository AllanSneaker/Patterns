using Bridge.Services;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryInfoProvider countryInfoProvider = new CountryInfoProvider(new GermanyDataService());
            Console.WriteLine(countryInfoProvider);

            countryInfoProvider = new CountryInfoProvider(new UnitedKingdomDataService());
            Console.WriteLine(countryInfoProvider);

            countryInfoProvider = new CountryInfoProvider(new RussianDataService());
            Console.WriteLine(countryInfoProvider);

        }
    }
}
