using System;

namespace exercicos
{
	class Lista2
	{
		public void exe1()
		{
			// 1 - Criar um algoritmo que gere um vetor de 8 posições, onde os valores de cada posição seja o cubo de cada índice.
			double[] vetor = new double[8];
			for (int i = 0; i < vetor.Length; i++)
			{
				vetor[i] = Math.Pow(i,3);
                Console.WriteLine($" Vetor[{i}] = {vetor[i]}");
			}
		}
		public void exe2()
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

		public void exe3()
        {
			double[] vetorA = new double[10];
			double x = 0;
			double[] vetorM = new double[vetorA.Length];
            Console.Write("Informe o valore multiplicador: ");
			x = double.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            Console.WriteLine("Informe os dados do Vetor A:");
			for(int i = 0; i < vetorA.Length; i++)
            {
                Console.Write($"vetorA[{i}] = ");
				vetorA[i] = double.Parse(Console.ReadLine());
				vetorM[i] = vetorA[i] * x;
            }
			Console.WriteLine("------------");
			for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine($"VetorA[{vetorA[i]}] * {x} = VetorM[{vetorM[i]}]");
            }
			//Dava pra fazer tudo em 1 for, porém achei mais legivel dividir em 2.
        }
	}	
}
