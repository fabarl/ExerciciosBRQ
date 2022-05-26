using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcL1 = 0; // Coloque o número do exercicio que deseja ver a resposta, deixe 0 para não ver essa Lista!
            Lista1 lista1 = new Lista1();
            switch(opcL1)
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
// ------------------------------------- LISTA 2 ----------------------------------------------
            int opcL2 = 3;  // Coloque o número do exercicio que deseja ver a resposta, deixe 0 para não ver essa Lista!
            Lista2 lista2 = new Lista2();
            switch (opcL2)
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
                    //lista2.exe4();
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
}
