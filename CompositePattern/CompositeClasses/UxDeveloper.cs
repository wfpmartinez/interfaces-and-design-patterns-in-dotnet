using CompositePattern.Interfaces.CompositeClasses;

namespace CompositePattern.CompositeClasses
{
    // leaf class
    public class UxDeveloper : Employee
    {
        public UxDeveloper(string name, string role) : base(name, role)
        {
        }
    }
}