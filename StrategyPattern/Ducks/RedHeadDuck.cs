using StrategyPattern.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real RedHead duck");
        }
    }
}
