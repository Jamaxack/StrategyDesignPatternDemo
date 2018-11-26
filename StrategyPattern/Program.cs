using StrategyPattern.Behaviors;
using StrategyPattern.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            var rubberDuck = new RubberDuck();
            var decoyDuck = new DecoyDuck();


            mallardDuck.Display();
            mallardDuck.PerformQuack();
            rubberDuck.Display();
            rubberDuck.PerformQuack();
            decoyDuck.Display();
            decoyDuck.PerformQuack();


            decoyDuck.Display();
            decoyDuck.PerformFly();


            decoyDuck.Display();
            decoyDuck.FlyBehavior = new FlyRocketPowered();
            decoyDuck.PerformFly();


            Console.ReadLine();
        }
    }
}
