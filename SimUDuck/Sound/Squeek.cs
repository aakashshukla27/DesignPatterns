﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Sound
{
    class Squeek : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeek");
        }
    }
}
