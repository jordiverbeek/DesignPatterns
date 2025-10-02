using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Syrup : CondimentDecorator
    {
        public Syrup(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            switch (this.Size)
            {
                case Size.TALL:
                    return baseBeverage.cost() - 0.13;

                case Size.GRANDE:
                    return baseBeverage.cost() + 0;

                case Size.VENDI:
                    return baseBeverage.cost() + 0.17;

                default:
                    break;
            }
            return 0.23 + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Syrup";
        }
    }
}
