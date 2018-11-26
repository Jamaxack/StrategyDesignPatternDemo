﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviors
{
    public class Mute : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Mute");
        }
    }
}
