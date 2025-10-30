using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Tuner
    {
        private Amplifier _amplifier;
        public Tuner(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Tuner aan");
        }

        public void Off()
        {
            Console.WriteLine("Tuner uit");
        }

        public void setAM()
        {

        }

        public void setFM()
        {

        }

        public void setFrequency()
        {

        }

    }
}