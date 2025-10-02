using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class IceCream : CondimentDecorator
    {
        public IceCream(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            switch (this.Size)
            {
                case Size.TALL:
                    return baseBeverage.cost() - 0.2;

                case Size.GRANDE:
                    return baseBeverage.cost() + 0;

                case Size.VENDI:
                    return baseBeverage.cost() + 0.2;

                default:
                    break;
            }

            return 0.40 + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", IceCream";
        }
    }
}
