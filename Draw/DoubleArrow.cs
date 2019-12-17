﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class DoubleArrow : Arrow
    {
        public override void Print()
        {
            Console.Write("<");
            base.Print();
        }

    }
}
