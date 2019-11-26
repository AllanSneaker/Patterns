using Iterator.Interfaces;
using Iterator.Models;
using System.Collections.Generic;


namespace Iterator.Implementations
{
    public class Collection : ICollection
    {
        private List<Employee> employees = new List<Employee>();
        public Iterator CreateIterator() => new Iterator(this);

        public int Count => employees.Count; 

        public Employee GetEmployee(int indexPosition)
        {
            return employees[indexPosition];
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
