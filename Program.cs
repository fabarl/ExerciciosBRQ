using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicos
{
    class Program
    {
        static void respostaLista(int lista, int exercicio)
        {
            if (lista == 1)
            {
                Lista1 lista1 = new Lista1();
                switch (exercicio)
                {
                    case 1:
                        lista1.exe1();
                        break;
                    case 2:
                        lista1.exe2();
                        break;
                    case 3:
                        lista1.exe3();
                        break;
                    case 4:
                        lista1.exe4();
                        break;
                    case 5:
                        lista1.exe5();
                        break;
                    case 6:
                        lista1.exe6();
                        break;
                }
            }
            else if (lista == 2)
            {
                Lista2 lista2 = new Lista2();
                switch (exercicio)
                {
                    case 1:
                        lista2.exe1();
                        break;
                    case 2:
                        lista2.exe2();
                        break;
                    case 3:
                        lista2.exe3();
                        break;
                    case 4:
                        lista2.exe4();
                        break;
                    case 5:
                        // lista2.exe5();
                        break;
                    case 6:
                        //lista2.exe6();
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            int nLista, nExercicio;
            Console.Write("Insira o Número da Lista: ");
            nLista = int.Parse(Console.ReadLine());
            Console.Write($"Lista {nLista}, insira o Número do exercicio: ");
            nExercicio = int.Parse(Console.ReadLine());
            respostaLista(nLista,nExercicio);

        }
    }
}
