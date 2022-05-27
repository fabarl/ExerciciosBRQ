using System;
using System.Linq;

namespace exercicios
{
    class Lista6
    {
        public static void Exe1()
        {
            // 1 - Criar um algoritmo que gere um vetor de 8 posições, onde os valores de cada posição seja o cubo de cada índice.
            double[] vetor = new double[8];
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = Math.Pow(i, 3);
                Console.WriteLine($" Vetor[{i}] = {vetor[i]}");
            }
        }

        public static void Exe2()
        {
            //2 - Dado um vetor V:
            //Crie um algoritmo que gere um vetor V2 a partir do dobro de cada valor de V.Gere os resultados no console.
            int[] v = { 5, 1, 4, 2, 7, 8, 3, 6 };
            int[] v2 = new int[v.Length];
            Console.WriteLine("Resultado:");
            for (int i = 0; i < v.Length; i++)
            {
                v2[i] = v[i] * 2;
                Console.WriteLine($"Vetor1[{i}] = {v[i]} | Vetor2[{i}] = {v2[i]}");
            }
        }

        public static void Exe3()
        {
            double[] vetorA = new double[10];
            double[] vetorM = new double[vetorA.Length];
            Console.Write("Informe o valore multiplicador: ");

            var x = EntradaDouble();

            Console.WriteLine("------------");
            Console.WriteLine("Informe os dados do Vetor A:");
            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write($"vetorA[{i}] = ");
                vetorA[i] = EntradaDouble();
                vetorM[i] = vetorA[i] * x;
                Console.WriteLine($"VetorA[{vetorA[i]}] * {x} = VetorM[{vetorM[i]}]");
            }
        }

        public static void Exe4()
        {
            string[] vetorNome = new string[5];
            Console.WriteLine("Insira o nome das 5 Pessoas:");
            for (int i = 0; i < vetorNome.Length; i++)
            {
                Console.Write($"Nome da {i + 1} pessoa: ");
                vetorNome[i] = Console.ReadLine();
            }
            Console.Write("Qual nome deseja Procurar: ");
            string nome = Console.ReadLine();

            var existe = vetorNome.ToArray().Any(t => t.ToUpper() == nome.ToString().ToUpper());
            Console.WriteLine(existe ? "ACHEI" : "NÃO ACHEI");
        }

        private static double EntradaDouble()
        {
            try
            {
                var entrada = Convert.ToDouble(Console.ReadLine());
                ValidaEntradaDouble(entrada);
                return entrada;
            }
            catch (Exception)
            {
                Console.WriteLine("Valor menor ou igual a zero");
                EntradaDouble();
                return 0;
            }
        }

        private static double ValidaEntradaDouble(double entrada)
        {
            while (entrada <= 0)
            {
                try
                {
                    Console.WriteLine("Valor menor ou igual a zero");
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

