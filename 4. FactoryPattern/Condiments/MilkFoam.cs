﻿using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class MilkFoam : CondimentDecorator
    {
        public MilkFoam(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            switch (this.Size)
            {
                case Size.TALL:
                    return baseBeverage.cost() - 0.05;

                case Size.GRANDE:
                    return baseBeverage.cost() + 0;

                case Size.VENDI:
                    return baseBeverage.cost() + 0.15;

                default:
                    break;
            }
            return 0.10 + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", MilkFoam";
        }
    }
}
