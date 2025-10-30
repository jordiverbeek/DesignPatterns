using System;

namespace Singleton
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        // ✅ Eager instantiation — de instantie wordt meteen aangemaakt
        private static readonly ChocolateBoiler uniqueInstance = new ChocolateBoiler();

        // ✅ Private constructor voorkomt externe instanties
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        // ✅ Publieke methode om het enkele (singleton) object te verkrijgen
        public static ChocolateBoiler GetInstance()
        {
            return uniqueInstance;
        }

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        // To fill the boiler it must be empty and once it is full, we set the empty and boiled flag
        public void Fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Filling the boiler with a milk/chocolate mixture...");
            }
        }

        // To drain the boiler, it must be full (non empty) and also boiled.
        // Once it is drained we set empty back to true
        public void Drain()
        {
            if (!empty && boiled)
            {
                empty = true;
                Console.WriteLine("Draining the boiled chocolate mixture...");
            }
        }

        // To boil the mixture, the boiler has to be full and not already boiled.
        // Once it is boiled we set the boiled flag to true
        public void Boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
                Console.WriteLine("Boiling the mixture...");
            }
        }
    }
}