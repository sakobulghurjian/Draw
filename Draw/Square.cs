using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Square : Rectangle
    {
        internal int Length;

        public Square(int  Height=5, int Weight=5)
        {
            if (Height==Weight)
            {
                Length = Height;
            }
            else
            {
                Length = (Height + Weight) / 2;
            }
        }

    }
}
