using StrategyPattern.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public abstract class Duck
    {
        public FlyBehavior FlyBehavior { get; set; }
        public QuackBehavior QuackBehavior { get; set; }

        public Duck()
        {

        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys.");
        }

    }
}
