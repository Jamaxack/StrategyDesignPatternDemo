using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors
{
    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
