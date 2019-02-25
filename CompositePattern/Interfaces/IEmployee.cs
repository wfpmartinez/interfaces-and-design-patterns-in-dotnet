using System.Collections.Generic;

namespace CompositePattern.Interfaces
{
    // Component interface
    public interface IEmployee
    {
        void GetSubordinates();
        string Name { get; set; }
        string Role { get; set; }
        List<IEmployee> Subordinates { get; set; }
    }
}