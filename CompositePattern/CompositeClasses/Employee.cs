using System;
using System.Collections.Generic;

namespace CompositePattern.Interfaces.CompositeClasses
{
    // Component abtract class
    public abstract class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public List<IEmployee> Subordinates { get; set; } = new List<IEmployee>();

        public Employee(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public void GetSubordinates()
        {
            Console.WriteLine(string.Format("The Employee {0} with the role {1} has the following subordinates: \n", Name, Role));
            foreach (IEmployee employee in Subordinates)
            {
                Console.WriteLine(string.Format("{0} - {1}", employee.Name, employee.Role));
            }
        }
    }
}