using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors
{
    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.Write("I can't fly.");
        }
    }
}
