using System;
using NullObjectPattern.Interfaces;
using NullObjectPattern.Services;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmartPhoneService service = new SmartPhoneService();

            ISmartPhone iPhone = service.FindByBrand("apple");
            ISmartPhone galaxy = service.FindByBrand("samsung");
            ISmartPhone huawei = service.FindByBrand("huawei");

            Console.WriteLine(iPhone.Brand);
            Console.WriteLine(galaxy.Brand);
            Console.WriteLine(huawei.Brand);

            iPhone.TurOn();
            galaxy.TurOn();
            huawei.TurOn();

            Console.ReadKey();
        }
    }
}
