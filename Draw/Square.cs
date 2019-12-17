using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Square : Rectangle
    {
       private int Length;

        public Square()
        {
            Length = 5;
        }
        public Square(byte Weight,byte Height)
        {
            if (Height == Weight)
            {
                Length = Height;
            }
            else
            {
                Length = (Height + Weight) / 2;
            }
        }
        public override void Print()
        {
      
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(model + " ");
                }
                Console.WriteLine();

            }
        }
    }

    
}
