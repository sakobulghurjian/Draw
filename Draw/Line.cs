using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Line : Shape
    {
        public int Length { get; set; }
        public override void Print()
        {
            base.Print();
            for (int i = 0; i < Length; i++)
            {
                Console.Write(model+" ");
            }
        }
    }
}
