using Prototype.Extensions;
using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Factory
{
    public class EmployeeFactory
    {
        private static Contact _mainEpamKyivOffice = new Contact { WorkAddress = new Address { Country = "Ukraine", City = "Kyiv", Street = "14B Kudryashova Street" } };
        private static Contact _secondEpamUkraineOffice = new Contact { WorkAddress = new Address { Country = "Ukraine", City = "Kyiv", Street = "28 Fizkultury Street" } };

        private static Contact NewEmployee(string firstName, string lastName, int suite, Contact prototype)
        {
            var result = prototype.DeepCopy();
            result.FirstName = firstName;
            result.LastName = lastName;
            result.WorkAddress.Suite = suite;
            return result;
        }

        public static Contact NewMainOfficeEmployee(string firstName, string lastName, int suite)
        {
            return NewEmployee(firstName, lastName, suite, _mainEpamKyivOffice);
        }

        public static Contact SecondEpamUkraineOffice(string firstName, string lastName, int suite)
        {
            return NewEmployee(firstName, lastName, suite, _secondEpamUkraineOffice);
        }
    }
}
