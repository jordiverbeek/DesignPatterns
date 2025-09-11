using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();

            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.PerformSwim();
            Console.WriteLine("settings Fly and Quack behaviors to Rocket and Squeak");
            mallardDuck.SetFlyBehavior(new FlyWithRocket());
            mallardDuck.SetQuackBehavior(new Squeak());
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            Console.WriteLine();

            redheadDuck.Display();
            redheadDuck.PerformFly();
            redheadDuck.PerformQuack();
            redheadDuck.PerformSwim();
            Console.WriteLine("settings Fly and Quack behaviors to Rocket and Squeak");
            redheadDuck.SetFlyBehavior(new FlyWithRocket());
            redheadDuck.SetQuackBehavior(new Squeak());
            redheadDuck.PerformFly();
            redheadDuck.PerformQuack();
            Console.WriteLine();

            decoyDuck.Display();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
            decoyDuck.PerformSwim();
            Console.WriteLine("settings Fly and Quack behaviors to Rocket and Squeak");
            decoyDuck.SetFlyBehavior(new FlyWithRocket());
            decoyDuck.SetQuackBehavior(new Squeak());
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
            Console.WriteLine();

            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();  
            rubberDuck.PerformSwim();
            Console.WriteLine("settings Fly and Quack behaviors to Rocket and Squeak");
            rubberDuck.SetFlyBehavior(new FlyWithRocket());
            rubberDuck.SetQuackBehavior(new Squeak());
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();
            Console.WriteLine();
    
            robotDuck.Display();
            robotDuck.PerformFly();
            robotDuck.PerformQuack();
            robotDuck.PerformSwim();
            Console.WriteLine("settings Fly and Quack behaviors to Rocket and Squeak");
            robotDuck.SetFlyBehavior(new FlyWithRocket());
            robotDuck.SetQuackBehavior(new Squeak());
            robotDuck.PerformFly();
            robotDuck.PerformQuack();
            Console.WriteLine();

        }
    }
}