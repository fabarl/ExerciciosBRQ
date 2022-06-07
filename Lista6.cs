using System;
using System.Linq;

namespace exercicios
{
    class Lista6
    {
        public static void Exe1()// Exercício 1
        {
            // 1 - Criar um algoritmo que gere um vetor de 8 posições, onde os valores de cada posição seja o cubo de cada índice.
            double[] vetor = new double[8];
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = Math.Pow(i, 3);
                Console.WriteLine($" Vetor[{i}] = {vetor[i]}");
            }
        }
        public static void Exe2()// Exercício 2
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
        public static void Exe3()// Exercício 3
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
        public static void Exe4()// Exercício 4
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
        public static void Exe5()// Exercício 5
        {
            double[] q = new double[10];
            double maior=0;
            int pos=0;

           for(int i = 0; i < q.Length; i++)
            {
                Console.Write($"Informe um valor par para a Posição {i}: "); q[i] = EntradaDoubleExe5();
                if (maior < q[i])
                {
                    maior = q[i];
                    pos = i;
                }
            }
            Console.WriteLine($"O maior Valor é {maior} na Posição {pos}");
        }
        public static void Exe6()// Exercicio 6
        {
            int[] temp = new int[7];
            int tempSoma=0, mediaSemanal = 0, tempMaior = -99,tempMenor = 99, cont = 0;
            Console.Clear();
            Console.WriteLine("Entre com o valor da temperatura abaixo!");

            for(int i = 0; i < 7; i++)
            {
                Console.Write($"Dia {i+1}:"); temp[i] = EntradaTemp();
                if (tempMaior < temp[i]) tempMaior = temp[i];
                if (tempMenor > temp[i]) tempMenor = temp[i];
                tempSoma = tempSoma + (temp[i]);
            }
            mediaSemanal = tempSoma / temp.Length;
            foreach(int temperatura in temp)
            {
                if (mediaSemanal < temperatura) cont++;
            }
            Console.WriteLine($"Menor temperatura da semana = {ConversorTemp(tempMenor)}");
            Console.WriteLine($"Maior temperatura da semana = {ConversorTemp(tempMaior)}");
            Console.WriteLine($"Temperatura média semanal = {ConversorTemp(mediaSemanal)}");
            Console.WriteLine("Total de Dias com temperatura inferior a média semanal = " +cont);
        }
        public static void Exe7()// Exercicio 7
        {
            double[] vetor = new double[10];
            double aux;
            Console.Clear();
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Posição[{i+1}] - Informe o Número: ");
                vetor[i] = double.Parse(Console.ReadLine());
             }
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"VetorOrdenado[{i+1}] = {vetor[i]}");
            }
        }
        public static void Exe8()// Exercicio 8
        {
            static double soma(double arg1, double arg2, double arg3)
            {
                return arg1 + arg2 + arg3;
            }
            static double media(double vlr)
            {
                return vlr / 3;
            }
            Console.Clear();
            Console.WriteLine("Entre com os Números: ");
            Console.Write("Primeiro número: "); var num1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo número: "); var num2 = double.Parse(Console.ReadLine());
            Console.Write("Terceiro número: "); var num3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"A Soma dos valores é: {soma(num1, num2, num3)} e a Média é: {media(soma(num1, num2, num3))} "); 
        }
        public static void Exe9()// Exercício 9
        {
            Console.Clear();
            static string exercicio9(double numero)
            {
                if (numero > 0) return "P";
                else return "N";
            }
            Console.Write("Insira um número: "); var num = double.Parse(Console.ReadLine());
            Console.WriteLine(exercicio9(num));
        }
        public static void Exe10()// Exercicio 10
        {
            static string exercicios10(int numero)
            {
                string dado = Convert.ToString(numero);
                return Convert.ToString(dado.Length);
            }
            Console.Write("informe o Número: "); var num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Total de Digitos: {exercicios10(num)}");
        }

        //-------------Funções para validações e verificações dos exercícios acima-------------
        private static double EntradaDouble() //Verifica se a entrada Double é válida
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

        private static double ValidaEntradaDouble(double entrada) // Gera condicional se o dado inserido está dentro do exigido
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

        private static double EntradaDoubleExe5()// Valida entradas pares
        {
            var entrada = double.Parse(Console.ReadLine());
            try
            {
                if(entrada < 0 || entrada %2 != 0)
                {
                    Console.Write("Entrada inválida! Digite Novamente: ");
                    EntradaDoubleExe5();
                }
            }
            catch
            {
                Console.Write("Entrada inválida! Digite Novamente: ");
                EntradaDoubleExe5();
            }
            return entrada;
        }

        private static int EntradaTemp()
        {
            try
            {
                int entrada = int.Parse(Console.ReadLine());
                return entrada;
            }catch
            {
                Console.Write("[ERRO} insira um valor inteiro: ");
                EntradaTemp();
                return 0;
            }
        }

        private static string ConversorTemp(int temp)
        {

            if (temp < 0)
            {
                temp = temp * -1;
                return $"{temp} Negativo";
            }

            if (temp > 0)return $"{temp} Positivo";

            return $"{temp}";
        }
    }
}

