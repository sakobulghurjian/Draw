using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Shape
    {
         protected string model="*";

        public virtual void Print()
        {
            Console.Write(" ");
        }
    }
}
