using System;
using System.Collections.Generic;
using CompositePattern.Interfaces;
using CompositePattern.CompositeClasses;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee manager1 = new ProjectManager("Peter Simons", "Project Manager");
            IEmployee manager2 = new ProjectManager("Tim Hood", "Project Manager");
            IEmployee accountManager = new AccountManager("John Doe", "Account Manager");

            IList<IEmployee> frontendDevs = new List<IEmployee>() {
                new FrontEndDeveloper("Nicole Carlson", "Angular Developer"),
                new FrontEndDeveloper("Sean Perkins", "React Developer"),
                new FrontEndDeveloper("Heather Ryan", "Vue Developer")
            };

            IList<IEmployee> backendDevs = new List<IEmployee>() {
                new BackEndDeveloper("Lesa Sanders", ".Net Developer"),
                new BackEndDeveloper("Nelson Neal", "Python Developer")
            };

            IList<IEmployee> uxDevs = new List<IEmployee>() {
                new UxDeveloper("Scott Hoffman", "UX Specialist"),
                new UxDeveloper("Amelia Gordon", "UX Specialist")
            };

            manager1.Subordinates.AddRange(frontendDevs);
            manager1.Subordinates.AddRange(uxDevs);
            manager2.Subordinates.AddRange(backendDevs);

            accountManager.Subordinates.Add(manager1);
            accountManager.Subordinates.Add(manager2);

            accountManager.GetSubordinates();
        }
    }
}
