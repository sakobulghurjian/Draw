using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Rectangle : Shape
    {
        protected int Height { get; set; }
        protected int Weight { get; set; }

        public  Rectangle()
        {
            Height = 10;
            Weight = 5;
        }
        public Rectangle(int Height, int Weight)
        {
            this.Weight = Weight;
            this.Height = Height;
        }
        public override void Print()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Weight; j++)
                {
                    Console.Write(model + " ");
                }
                Console.WriteLine();
               
            }
        }
    }
}
