using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        public Chocolate(Beverage beverage = null)
        {
            description = "Chocolate";
            this.baseBeverage = beverage;

        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }
        public override double cost()
        {
            double price = 1.99;
            switch (this.Size)
            {
                case Size.TALL:
                    price = price - 0.055;
                    break;

                case Size.GRANDE:
                    price = price + 0.0;
                    break;

                case Size.VENDI:
                    price = price + 0.15;
                    break;

                default:
                    break;
            }
            if (baseBeverage != null)
            {
                switch (this.Size)
                {
                    case Size.TALL:
                        price = price - 0.05;
                        break;

                    case Size.GRANDE:
                        price = price + 0;
                        break;

                    case Size.VENDI:
                        price = price + 0.15;
                        break;

                    default:
                        break;
                }

            }
            return price;
        }
    }
}
