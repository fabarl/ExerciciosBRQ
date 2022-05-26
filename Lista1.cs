using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicos
{
    internal class Lista1
    {
        void exe1()
        {
            int x,y,b;
            x = 15;
            y = 20;
            Console.WriteLine(x);
            b = 3;
            Console.WriteLine($"{x} {y}");
        }
        void exe2()
        {
            int a, b, c;
            a = 15;
            b = 3;
            c = a * b;
            Console.WriteLine(c);
            b = 10;
            c = a - b;
            Console.WriteLine($"{a} {b} {c}");

        }
    }
}
