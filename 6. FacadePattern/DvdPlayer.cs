using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DVD player aan");
        }
        public void Off()
        {
            Console.WriteLine("DVD player uit");
        }
        public void Eject()
        {
            Console.WriteLine("DVD player eject");
        }
        public void Pause()
        {
            Console.WriteLine("DVD player pause");
        }
        public void Play(string movie)
        {
            Console.WriteLine("DVD player play");
        }
        public void SetSurroundAudio()
        {

        }
        public void SetTWoChannelAudio()
        {

        }
        public void Stop()
        {
            Console.WriteLine("DVD player stop");
        }
    }
}