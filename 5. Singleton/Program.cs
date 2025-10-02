namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Twee keer een instantie opvragen
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            // Controleren of ze hetzelfde object zijn
            Console.WriteLine(Object.ReferenceEquals(boiler1, boiler2)
                ? "Beide verwijzen naar dezelfde instantie (Singleton werkt!)"
                : "Er zijn meerdere instanties (Singleton werkt NIET)");

            // Extra: de functionaliteit testen
            boiler1.fill();
            boiler1.boil();
            boiler1.drain();

            Console.WriteLine($"IsEmpty: {boiler1.IsEmpty}, IsBoiled: {boiler1.IsBoiled}");
        }
    }
}
