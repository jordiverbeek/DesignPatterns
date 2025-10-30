using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Projector
    {
        private DvdPlayer _dvdPlayer;
        public Projector()
        {
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("projecter aan");
        }

        public void Off()
        {
            Console.WriteLine("projecter uit");
        }

        public void TvMode()
        {

        }

        public void WideScreenMode()
        {

        }
    }
}