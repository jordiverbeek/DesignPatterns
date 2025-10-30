namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);


            var homeTheater = new HomeTheaterFacade(popcornPopper, lights, screen, projector, amp, dvdPlayer);

            homeTheater.WatchMovie();

            Console.WriteLine("Film gestart!");

            Console.WriteLine("--------------------------");

            homeTheater.EndMovie();

            Console.WriteLine("Film gestopt!");
        }
    }
}