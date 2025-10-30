using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater Lights aan");
        }

        public void Off()
        {
            Console.WriteLine("Theater Lights uit");
        }

        public void Dim(int value)
        {

        }
    }
}