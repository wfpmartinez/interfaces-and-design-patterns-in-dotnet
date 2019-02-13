using System.Collections.Generic;
using System.Linq;
using NullObjectPattern.Interfaces;

namespace NullObjectPattern.Services
{
    public class SmartPhoneService : ISmartPhoneService
    {
        //mock data
        private List<ISmartPhone> smartPhones;

        public SmartPhoneService()
        {
            smartPhones = new List<ISmartPhone>() {
                new AppleIPhone(),
                new SamsungGalaxy()
            };
        }

        public ISmartPhone FindByBrand(string brandName)
        {
            return smartPhones
                .FirstOrDefault(s => s.Brand.ToLower() == brandName.ToLower()) ?? new NullPhone();
        }
    }
}