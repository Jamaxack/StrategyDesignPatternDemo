using StrategyPattern.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Rubber duck");
        }
    }
}
