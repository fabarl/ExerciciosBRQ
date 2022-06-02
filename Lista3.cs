using System;
using System.Linq;


namespace exercicios
{
    class Lista3
    {
        public static void Exe1()
        {
            double nota1, nota2, nota3,media;
            Console.Write("Coloque a nota 1: ");  nota1 = EntradaDoubleExe1();
            Console.Write("Coloque a nota 2: ");  nota2 = EntradaDoubleExe1();
            Console.Write("Coloque a nota 3: ");  nota3 = EntradaDoubleExe1();
            media = (nota1 + nota2 + nota3) / 3;
            if (media >=6)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
        public static void Exe2()
        {
            double vlr1, vlr2, vlr3, maior = 0;
            Console.Write("Coloque o Valor 1: "); vlr1 = Double.Parse(Console.ReadLine());
            Console.Write("Coloque o Valor 2: "); vlr2 = Double.Parse(Console.ReadLine());
            Console.Write("Coloque o Valor 3: "); vlr3 = Double.Parse(Console.ReadLine());
            if (vlr1 >= maior)
            {
                maior = vlr1;
            }
            if (vlr2 >= maior)
            {
                maior = vlr2;
            }
            if (vlr3 >= maior)
            {
                maior = vlr3;
            }
        }


        private static double EntradaDoubleExe1()
        {
            try
            {
                var entrada = Convert.ToDouble(Console.ReadLine());
                ValidaEntradaDoubleExe1(entrada);
                return entrada;
            }
            catch (Exception)
            {
                Console.Write("[ERRO] Entre com valor entre 0 e 10, insira Novamente");
                EntradaDoubleExe1();
                return 0;
            }
        }

        private static double ValidaEntradaDoubleExe1(double entrada)
        {
            while (entrada < 0 || entrada > 10)
            {
                try
                {
                    Console.Write("[ERRO] Entre com valor entre 0 e 10, insira Novamente");
                    entrada = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    entrada = 0;
                }
            }
            return entrada;
        }
    }
}
