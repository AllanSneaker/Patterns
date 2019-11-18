using Prototype.Factory;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var ivan = EmployeeFactory.NewMainOfficeEmployee("Ivan", "Ivanov", 251);
            var olga = EmployeeFactory.SecondEpamUkraineOffice("Olga", "Ponomareva", 221);

            Console.WriteLine($"Employee with name {ivan.FirstName} {ivan.LastName} work at the {ivan.WorkAddress.Street} office");
            Console.WriteLine($"Employee with name {olga.FirstName} {olga.LastName} work at the {olga.WorkAddress.Street} office");
        }
    }
}
