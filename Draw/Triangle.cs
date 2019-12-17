using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Triangle : Shape
    {
        public int Length { get; set; }
        public override void Print()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < 1+i; j++)
                {
                    Console.Write(model+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
