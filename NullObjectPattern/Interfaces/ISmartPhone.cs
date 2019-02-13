namespace NullObjectPattern.Interfaces
{
    public interface ISmartPhone
    {
        string Brand { get; set; }
        void TurOn();
        void TurnOff();
    }
}