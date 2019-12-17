using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Arrow : Line
    {
        public override void Print()
        {
            base.Print();
            Console.Write(">");

        }
    }
    
}
