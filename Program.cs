using System;

namespace exercicios
{
    class Program
    {
        static void Main()
        {
            int nLista, nExercicio;
            Console.Write("Insira o Número da Lista: ");
            nLista = Entrada();
            Console.Write($"Lista {nLista}, insira o Número do exercicio: ");
            nExercicio = Entrada();
            RespostaLista(nLista, nExercicio);
        }
        private static void RespostaLista(int lista, int exercicio)
        {
            switch (lista)
            {
                case 1: ExeciciosLista1(exercicio); break;
                case 2: ExeciciosLista6(exercicio); break;
                default: Console.WriteLine("Lista não encontrada"); break;
            }
        }
        private static void ExeciciosLista1(int exercicio)
        {
            switch (exercicio)
            {
                case 1: Lista1.Exe1(); break;
                case 2: Lista1.Exe2(); break;
                case 3: Lista1.Exe3(); break;
                case 4: Lista1.Exe4(); break;
                case 5: Lista1.Exe5(); break;
                case 6: Lista1.Exe6(); break;
                default: Console.WriteLine("Exercicio não encontrado"); break;
            }
        }
        private static void ExeciciosLista6(int exercicio)
        {
            switch (exercicio)
            {
                case 1: Lista6.Exe1(); break;
                case 2: Lista6.Exe2(); break;
                case 3: Lista6.Exe3(); break;
                case 4: Lista6.Exe4(); break;
                case 5: /*lista2.exe5()*/; break;
                case 6: /*lista2.exe6();*/ break;
                default: Console.WriteLine("Exercicio não encontrado"); break;
            }
        }
        private static int Entrada()
        {
            try
            {
                var entrada = Convert.ToInt16(Console.ReadLine());
                ValidaEntrada(entrada);
                return entrada;
            }
            catch (Exception)
            {
                Console.WriteLine("Entrada inválida! Tente novamente");
                Entrada();
                return 0;
            }
        }
        private static int ValidaEntrada(int entrada)
        {
            while (entrada <= 0)
            {
                try
                {
                    Console.WriteLine("Entrada inválida! Tente novamente");
                    entrada = Convert.ToInt16(Console.ReadLine());
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
