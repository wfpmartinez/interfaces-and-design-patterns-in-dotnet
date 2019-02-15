using ObjectAdapterPattern.Interfaces;

namespace ObjectAdapterPattern
{
    public class Adapter : ITarget
    {
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request() {
            adaptee.SpecificMethod();
        }

        private Adaptee adaptee;
    }
}