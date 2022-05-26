using System;

namespace exercicios
{
    class Lista1
    {
        public static void Exe1()
        {
#pragma warning disable CS0219 // A variável "b" é atribuída, mas seu valor nunca é usado
            int x, y, b;
#pragma warning restore CS0219 // A variável "b" é atribuída, mas seu valor nunca é usado
            x = 15;
            y = 20;
            Console.WriteLine("Lista 1 - Exercicio 1");
            Console.WriteLine("x = " + x);
            b = 3;
            Console.WriteLine($" x = {x}, y = {y}");
        }
        public static void Exe2()
        {
            int a, b, c;
            a = 15;
            b = 3;
            c = a * b;
            Console.WriteLine("Lista 1 - Exercicio 2");
            Console.WriteLine("c = " + c);
            b = 10;
            c = a - b;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

        }
        public static void Exe3()
        {
            int x, y, z;
            x = 10;
            y = 12;
            z = x;
            y = z;
            x = y;
            Console.WriteLine("Lista 1 - Exercicio 3");
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
        }
        public static void Exe4()
        {
            int a, b;
            a = 10;
            b = a + 2;
            a = b + 1;
            b = a + 1;
            Console.WriteLine("Lista 1 - Exercicio 4");
            Console.WriteLine("a = " + a);
            a = b + 1;
            Console.WriteLine($"a = {a}, b = {b}");
        }
        public static void Exe5()
        {
            int x, y, z;
            x = 12;
            y = x;
            z = x + y;
            x = 20;
            y = 10;
            Console.WriteLine("Lista 1 - Exercicio 5");
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
        }
        public static void Exe6()
        {
            int a, b, c;
            a = 2;
            b = 3;
            a = a + b;
            c = a - b;
            Console.WriteLine("Lista 1 - Exercicio 6");
            Console.WriteLine("c = " + c);
            b = 5;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
