﻿using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Liqour : CondimentDecorator
    {
        public Liqour(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return 0.40 + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Liqour";
        }
    }
}
