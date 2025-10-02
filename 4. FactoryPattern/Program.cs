using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Stores;
using System.ComponentModel;
using DecoratorPattern.Factory;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CoffeeStore store = new CoffeeStore(new CoffeeFactory());

            
            store.OrderBeverage("espresso");
            store.OrderBeverage("doppio");
            store.OrderBeverage("lungo");
            store.OrderBeverage("macchiato");
            store.OrderBeverage("corretta");
            store.OrderBeverage("conpanna");
            store.OrderBeverage("cappuccino");
            store.OrderBeverage("americano");
            store.OrderBeverage("caffelatte");
            store.OrderBeverage("flatwhite");
            store.OrderBeverage("romana");
            store.OrderBeverage("morocchino");
            store.OrderBeverage("mocha");
            store.OrderBeverage("bicerin");
            store.OrderBeverage("breve");
            store.OrderBeverage("rafcoffee");
            store.OrderBeverage("meadraf");
            store.OrderBeverage("galao");
            store.OrderBeverage("caffeaffogato");
            store.OrderBeverage("viennacoffee");
            store.OrderBeverage("glace");
            store.OrderBeverage("chocolatemilk");
            store.OrderBeverage("demicreme");
            store.OrderBeverage("lattemacchiato");
            store.OrderBeverage("freddo");
            store.OrderBeverage("frappuccino");
            store.OrderBeverage("caramelfrappuccino");
            store.OrderBeverage("frappe");
            store.OrderBeverage("irishcoffee");

        }

       
    }
}