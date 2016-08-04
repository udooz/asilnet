using System;

namespace AsilNetCore.Tests
{
    public class Employee : IEquatable<Employee>
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public bool Equals(Employee other)
        {
            var result = string.Compare(Name, other.Name, StringComparison.CurrentCultureIgnoreCase);
            if (result == 0) return true;
            else return false;
        }
    }
}
