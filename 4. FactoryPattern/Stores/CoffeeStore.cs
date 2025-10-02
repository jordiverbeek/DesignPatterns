using DecoratorPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Stores
{
    internal class CoffeeStore
    {
        private CoffeeFactory factory;
        public CoffeeStore(CoffeeFactory factory) {
            this.factory = factory;
        }
        public Beverage OrderBeverage(string type)
        {
            Beverage beverage = factory.createCoffee(type);

            Console.WriteLine(type);
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
            Console.WriteLine("----------------------------------------------------------");

            return beverage;
        }
    }
}
