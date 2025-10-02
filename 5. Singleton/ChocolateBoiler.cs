using System;

namespace Singleton
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        private static ChocolateBoiler? instance;
        private static readonly object lockObject = new object();

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {   
                    if (instance == null)
                    {
                        instance = new ChocolateBoiler();
                    }
                }
            }
            return instance;
        }

        public void fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
            }
        }

        public void drain()
        {
            if (!empty && boiled)
            {
                empty = true;
            }
        }

        public void boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
            }
        }
    }
}
