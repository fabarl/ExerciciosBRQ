using System;
using System.Linq;
using System.Globalization;


namespace exercicios
{
    class Lista3
    {
        public static void Exe1() // Exercício 1
        {
            double nota1, nota2, nota3,media;
            Console.Write("Coloque a nota 1: ");  nota1 = EntradaDoubleExe1();
            Console.Write("Coloque a nota 2: ");  nota2 = EntradaDoubleExe1();
            Console.Write("Coloque a nota 3: ");  nota3 = EntradaDoubleExe1();
            media = (nota1 + nota2 + nota3) / 3;
            if (media >=6) Console.WriteLine("Aprovado");
            else Console.WriteLine("Reprovado");
        }
        public static void Exe2() // Exercício 2
        {
            double vlr1, vlr2, vlr3, maior = 0;
            Console.Write("Coloque o Valor 1: "); vlr1 = Double.Parse(Console.ReadLine());
            Console.Write("Coloque o Valor 2: "); vlr2 = Double.Parse(Console.ReadLine());
            Console.Write("Coloque o Valor 3: "); vlr3 = Double.Parse(Console.ReadLine());
            if (vlr1 >= maior)  maior = vlr1;
            if (vlr2 >= maior)  maior = vlr2;
            if (vlr3 >= maior)  maior = vlr3;
            Console.WriteLine($"{maior} É o maior.");
        }
        public static void Exe3() // Exercício 3
        {
            double vlr1, vlr2;
            Console.Write("Coloque o Valor 1: "); vlr1 = Double.Parse(Console.ReadLine());
            Console.Write("Coloque o Valor 2: "); vlr2 = Double.Parse(Console.ReadLine());
            if (vlr1 % vlr2 == 0) Console.Write("São multiplos!");
            else Console.WriteLine("Não são multiplos!");
        }
        public static void Exe4() // Exercício 4
        {
            double altura;
            string sexo;
            Console.WriteLine("[Calculo IMC]");
            Console.Write("Insira sua Altura: "); altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            do
            {
                Console.Write("Insira [ H ] para Homens e [ M ] para Mulher: ");
                sexo = Console.ReadLine();

                if (sexo == "M")  Console.WriteLine($"IMC : {Math.Truncate((62.1 * altura) - 44.7)}");

                if (sexo == "H")  Console.WriteLine($"IMC : {Math.Truncate((72.7 * altura) - 58)}");

            } while ( sexo == "" || (sexo != "M" && sexo != "H"));

        }
        public static void Exe5() // Exercício 5
        {
            Console.Write("Insira o 1 valor: "); var num1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o 2 valor: "); var num2 = double.Parse(Console.ReadLine());

            if (num1 == num2) Console.WriteLine("Números iguais!");
            if (num1 > num2)  Console.WriteLine("Primeiro é maior!");
            if (num2 > num1)  Console.WriteLine("Segundo maior!");
           
        }
        public static void Exe6() // Exercício 6
        {
            for (int i = 10; i > 0; i--) Console.WriteLine(i);
        }
        public static void Exe7() // Exercício 7
        {
            for (int i = 1; i<=50; i++)  if (i % 5 == 0) Console.WriteLine(i);
        }
        public static void Exe8() // Exercício 8
        {
            int num,vlr = 1;
            do
            {
                Console.Write("Insira um número maior que zero: "); num = int.Parse(Console.ReadLine());
            } while (num<=0);

            while (vlr <= num)
            {
                if (vlr % 2 == 0) Console.WriteLine(vlr);
                vlr++;
            }
        }
        public static void Exe9() // Exercício 9
        {
            for (int i = 1; i<=10; i++) Console.WriteLine($"7 x {i} = {7*i}");
        }
        public static void Exe10()// Exercicio 10
        {        
                int fib1 = 0, fib2 = 1, aux;
                for (int i = 0; i < 15; i++)
                {
                aux = fib1 + fib2;
                Console.Write(aux+",");
                fib2 = fib1;
                fib1 = aux;
                }
        }
        //Funções de validação
        //exercicio 1
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
        //Fim validação exercicio 1
        
        // Exercício 2
        private static string EntradaStringExe4()
        {
            try
            {
                var entrada = Console.ReadLine();
                ValidaEntradaStringExe4(entrada);
                return entrada;
            }
            catch (Exception)
            {
                Console.Write("[ERRO] Entre com [ H ] para Homem ou [ M ] para Mulher: ");
                
                return EntradaStringExe4();
            }
        }
        private static string ValidaEntradaStringExe4(string entrada)
        {
            while (entrada != "M" || entrada != "H")
            {
                try
                {
                    Console.Write("[ERRO] Entre com [ H ] para Homem ou [ M ] para Mulher: ");
                    entrada = Console.ReadLine();
                }
                catch (Exception)
                {
                    entrada = "Erro";
                }
            }
            return entrada;
        }
        //Fim validação exercicio 2
    }
}
