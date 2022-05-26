using System;

namespace exercicos
{
     class Lista1
    {
        public void exe1()
        {
            int x,y,b;
            x = 15;
            y = 20;
            Console.WriteLine("Lista 1 - Exercicio 1");
            Console.WriteLine(x);
            b = 3;
            Console.WriteLine($"{x},{y}");
        }
        public void exe2()
        {
            int a, b, c;
            a = 15;
            b = 3;
            c = a * b;
            Console.WriteLine("Lista 1 - Exercicio 2");
            Console.WriteLine(c);
            b = 10;
            c = a - b;
            Console.WriteLine($"{a},{b},{c}");

        }
        public void exe3()
        {
            int x, y, z;
            x = 10;
            y = 12;
            z = x;
            y = z;
            x = y;
            Console.WriteLine("Lista 1 - Exercicio 3");
            Console.WriteLine($"{x},{y},{z}");
        }
        public void exe4()
        {
            int a, b;
            a = 10;
            b = a + 2;
            a = b + 1;
            b = a + 1;
            Console.WriteLine("Lista 1 - Exercicio 4");
            Console.WriteLine(a);
            a = b + 1;
            Console.WriteLine($"{a},{b}");
        }
        public void exe5()
        {
            int x, y, z;
            x = 12;
            y = x;
            z = x + y;
            x = 20;
            y = 10;
            Console.WriteLine("Lista 1 - Exercicio 5");
            Console.WriteLine($"{x},{y},{z}");
        }
        public void exe6()
        {
            int a, b, c;
            a = 2;
            b = 3;
            a = a + b;
            c = a - b;
            Console.WriteLine("Lista 1 - Exercicio 6");
            Console.WriteLine(c);
            b = 5;
            Console.WriteLine($"{a},{b},{c}");
        }
    }
}
