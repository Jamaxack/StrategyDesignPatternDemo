﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket. WooHoo!");
        }
    }
}
