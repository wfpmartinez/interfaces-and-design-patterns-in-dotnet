using CompositePattern.Interfaces.CompositeClasses;

namespace CompositePattern.CompositeClasses
{
    // leaf class (which represents objects hierarchy which have children)
    public class ProjectManager : Employee
    {
        public ProjectManager(string name, string role) : base(name, role)
        {
        }
    }
}