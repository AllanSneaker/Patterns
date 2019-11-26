using Iterator.Implementations;
using Iterator.Models;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new Collection();

            collection.AddEmployee(new Employee("Anurag", 100));
            collection.AddEmployee(new Employee("Pranaya", 101));
            collection.AddEmployee(new Employee("Santosh", 102));
            collection.AddEmployee(new Employee("Priyanka", 103));
            collection.AddEmployee(new Employee("Abinash", 104));
            collection.AddEmployee(new Employee("Preety", 105));

            Implementations.Iterator iterator = collection.CreateIterator();

            for (var emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"Id : {emp.Id} & Name : {emp.Name}");
            }
        }
    }
}
