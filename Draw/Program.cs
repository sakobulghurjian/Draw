using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            Line l = new Line();
            l.Length = 10;
            Arrow a = new Arrow();
            a.Length = l.Length;
            DoubleArrow d = new DoubleArrow();
            d.Length = l.Length;
            l.Print();
            Console.WriteLine();
            Console.WriteLine();
            a.Print();
            Console.WriteLine();
            Console.WriteLine();
            d.Print();
            Console.WriteLine();
            Console.WriteLine();
            Rectangle r = new Rectangle();
            Square sq = new Square(4, 10);
            Rectangle sq1 = new Square();
            r.Print();
            Console.WriteLine();
            sq.Print();
            Console.WriteLine();
            sq1.Print();
            Console.WriteLine();
            Triangle t = new Triangle();
            t.Length = 10;
            t.Print();
            Console.ReadKey();
        }
    }
}
