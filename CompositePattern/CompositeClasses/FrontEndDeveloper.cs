using CompositePattern.Interfaces.CompositeClasses;

namespace CompositePattern.CompositeClasses
{
    // Leaf class
    public class FrontEndDeveloper : Employee
    {
        public FrontEndDeveloper(string name, string role) : base(name, role)
        {
        }
    }
}