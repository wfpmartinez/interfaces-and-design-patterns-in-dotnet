using CompositePattern.Interfaces.CompositeClasses;

namespace CompositePattern.CompositeClasses
{
    // Composite class (which represents objects hierarchy which have children)
    public class AccountManager : Employee
    {
        public AccountManager(string name, string role) : base(name, role)
        {
        }

        public override void GetSubordinates()
        {
            base.GetSubordinates();
            foreach (var pm in this.Subordinates)
            {
                pm.GetSubordinates();
            }
        }
    }
}