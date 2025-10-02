using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory

{
    internal class CoffeeFactory
    {
        public Beverage createCoffee(string type)
        {
            Beverage beverage = null;

            type = type.ToLower();
            switch (type){
                case "espresso":
                    beverage = new Espresso();
                    break;

                case "doppio":
                    beverage = new Espresso();
                    beverage = new CondimentEspresso(beverage);
                    break;

                case "lungo":
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    break;

                case "macchiato":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    break;

                case "corretta":
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    break;

                case "conpanna":
                    beverage = new Espresso();
                    beverage = new Whip(beverage);
                    break;

                case "cappuccino":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "americano":
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    beverage = new Water(beverage);
                    break;

                case "caffelatte":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "flatwhite":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    break;

                case "romana":
                    beverage = new Espresso();
                    beverage = new Lemon(beverage);
                    break;

                case "morocchino":
                    beverage = new Espresso();
                    beverage = new CondimentChocolate(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "mocha":
                    beverage = new Espresso();
                    beverage = new CondimentChocolate(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "bicerin":
                    beverage = new Espresso();
                    beverage = new BlackChocolate(beverage);
                    beverage = new WhiteChocolate(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "breve":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new HalfMilk(beverage);
                    break;

                case "rafcoffee":
                    beverage = new Espresso();
                    beverage = new VanillaSugar(beverage);
                    beverage = new Cream(beverage);
                    break;

                case "meadraf":
                    beverage = new Espresso();
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    break;

                case "galao":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "caffeaffogato":
                    beverage = new Espresso();
                    beverage = new CondimentEspresso(beverage);
                    beverage = new IceCream(beverage);
                    break;

                case "viennacoffee":
                    beverage = new Espresso();
                    beverage = new CondimentEspresso(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "glace":
                    beverage = new Espresso();
                    beverage = new IceCream(beverage);
                    break;

                case "chocolatemilk":
                    beverage = new Chocolate();
                    beverage = new Milk(beverage);
                    beverage = new Milk(beverage);
                    break;

                case "demicreme":
                    beverage = new Espresso();
                    beverage = new CondimentEspresso(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    break;

                case "lattemacchiato":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "freddo":
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    beverage = new Ice(beverage);
                    break;

                case "frappuccino":
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "caramelfrappuccino":
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    break;

                case "frappe":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new IceCream(beverage);
                    break;

                case "irishcoffee":
                    beverage = new Espresso();
                    beverage = new CondimentEspresso(beverage);
                    beverage = new Whiskey(beverage);
                    beverage = new Whip(beverage);
                    break;

                default: 
                    Console.WriteLine("wrong type, try again" + type);
                    break;
            }
            return beverage;
        }
    }
}
