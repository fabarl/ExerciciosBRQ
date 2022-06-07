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
                case 3: ExeciciosLista3(exercicio); break;
                case 4: ExeciciosLista4(exercicio); break;
                case 6: ExeciciosLista6(exercicio); break;
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
        private static void ExeciciosLista3(int exercicio)
        {
            switch (exercicio)
            {
                case 1: Lista3.Exe1(); break;
                case 2: Lista3.Exe2(); break;
                case 3: Lista3.Exe3(); break;
                case 4: Lista3.Exe4(); break;
                case 5: Lista3.Exe5(); break;
                case 6: Lista3.Exe6(); break;
                case 7: Lista3.Exe7(); break;
                case 8: Lista3.Exe8(); break;
                case 9: Lista3.Exe9(); break;
                case 10: Lista3.Exe10(); break;
                default: Console.WriteLine("Exercicio não encontrado"); break;
            }
        }
        private static void ExeciciosLista4(int exercicio)
        {
            switch (exercicio)
            {
                case 1: Lista4.Exe1(); break;
                case 2: Lista4.Exe2(); break;
                case 3: Lista4.Exe3(); break;
                case 4: Lista4.Exe4(); break;
                case 5: Lista4.Exe5(); break;
                case 6: Lista4.Exe6(); break;
                case 7: Lista4.Exe7(); break;
                case 8: Lista4.Exe8(); break;
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
                case 5: Lista6.Exe5(); break;
                case 6: Lista6.Exe6(); break;
                case 7: Lista6.Exe7(); break;
                case 8: Lista6.Exe8(); break;
                case 9: Lista6.Exe9(); break;
                case 10: Lista6.Exe10(); break;
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
