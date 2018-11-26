using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings.");
        }
    }
}
