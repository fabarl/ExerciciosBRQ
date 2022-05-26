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
            int opc = 0;
            Lista1 lista1 = new Lista1();
            switch(opc){
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
    }
}
