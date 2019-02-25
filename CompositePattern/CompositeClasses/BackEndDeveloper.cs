using CompositePattern.Interfaces.CompositeClasses;

namespace CompositePattern.CompositeClasses
{
    // leaf class
    public class BackEndDeveloper : Employee
    {
        public BackEndDeveloper(string name, string role) : base(name, role)
        {
        }
    }

}