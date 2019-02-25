using CompositePattern.Interfaces.CompositeClasses;

namespace CompositePattern.CompositeClasses
{
    // Composite class (which represents objects hierarchy which have children)
    public class AccountManager : Employee
    {
        public AccountManager(string name, string role) : base(name, role)
        {
        }
    }
}