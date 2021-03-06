using System;
using System.Linq;
using System.Globalization;



namespace exercicios
{
    class Lista4
    {
        public static void Exe1() //Exercício 1
        {
            int num1, num2, num3;
            Console.WriteLine("Insira os Valores inteiros e Positivos");
            Console.Write("Insira o 1 valor: "); num1 = VerIntPos();
            Console.Write("Insira o 2 valor: "); num2 = VerIntPos();
            Console.Write("Insira o 3 valor: "); num3 = VerIntPos();

            Console.WriteLine("Resultado : "+(num1+num2)/num3);
        }
        public static void Exe2() //Exercício 2
        {
            double num1, num2, num3;
            double peso1 = 2, peso2 = 3, peso3 = 5;
          
            Console.Write("Insira a 1 nota : "); num1 = ValidaNota();
            Console.Write("Insira a 2 nota : "); num2 = ValidaNota();
            Console.Write("Insira a 3 nota : "); num3 = ValidaNota();
            Console.WriteLine($"Média = {((num1*peso1) + (num2*peso2) + (num3*peso3)) / (peso1+peso2+peso3)}");
        }
        public static void Exe3() //Exercício 3
        {
            int seg,hora=0,minuto=0,aux;
            Console.Write("Entre com a duração do evento em Segundos: ");
            aux = VerIntPos();
            hora = aux / 3600;
            minuto = ((aux - (hora * 3600)) / 60);
            seg = (aux - (hora * 3600) - (minuto * 60));
            Console.WriteLine($"Evento durou {hora} horas {minuto} minutos {seg} segundos! ");
        }
        public static void Exe4() //Exercício 4
        {
            double area;
            Console.WriteLine("Informe o valor do Lado do Triângulo: ");
            area = double.Parse(Console.ReadLine());
            Console.Write($"Resultado = "+ Math.Sqrt(3) / 4 * area * area);
        }
        public static void Exe5() //Exercício 5
        {
            int num1,num2,num3;
            Console.WriteLine("Insira os Valores inteiros e Positivos");
            Console.Write("Insira o 1 valor: "); num1 = VerIntPos();
            Console.Write("Insira o 2 valor: "); num2 = VerIntPos();
            Console.Write("Insira o 3 valor: "); num3 = VerIntPos();
            //Console.WriteLine($"Resultado {(num1+num2)^2+num3}");
            Console.WriteLine($"Resultado com math {Math.Pow(num1+num2,2)+num3}");
        }
        public static void Exe6() //Exercício 6
        {
            double vlr,vlr2;
            Console.Write("Insira o Valor: "); vlr = Double.Parse(Console.ReadLine());
            vlr2 = vlr - 1;
            Console.WriteLine("Resultado : " + vlr2*2);
        }
        public static void Exe7() //Exercício 7
        {
            int populacao,vBranco,vNulo,vValido;
            do {
                Console.Write("Informe a quantidade total de eleitores: "); populacao = VerIntPos();
                Console.Write("Informe a quantidade de Votos Brancos: "); vBranco = VerIntPos();
                Console.Write("Informe a quantidade de Votos Nulos: "); vNulo = VerIntPos();
                Console.Write("Informe a quantidade de Votos Válidos: "); vValido = VerIntPos();
                if (populacao < (vBranco + vNulo + vValido)) Console.WriteLine("Fraude Eleitoral detectada! insira os dados novamente!");
            } while (populacao < (vBranco+vNulo+vValido));
            Console.WriteLine(" ");

            Console.WriteLine($"Votos Brancos equivalem a {(vBranco*100) / populacao}% dos eleitores");
            Console.WriteLine($"Votos Nulos equivalem a {(vNulo*100) / populacao}% dos eleitores");
            Console.WriteLine($"Votos Válidos equivalem a {(vValido*100) / populacao}% dos eleitores");
        }
        public static void Exe8() //Exercício  8
        {
            double cFabrica, cDistri, cImp;
            Console.Write("insira o Valor de Fabrica do veiculo: "); cFabrica = double.Parse(Console.ReadLine());
            cDistri = (cFabrica * 30) / 100;
            cImp = (cFabrica * 45) / 100;
            Console.Write("valor De venda final: "+(cFabrica+cDistri+cImp));
        }

        // validação de valor inteiro positivo
        public static int VerIntPos()
        {       
            try
            {
                var entrada = int.Parse(Console.ReadLine());
                if (entrada < 0)
                {
                    Console.Write("Erro - Insira um Valor positivo: ");
                    VerIntPos();
                }
                return entrada;
            }
            catch
            {
                Console.Write("Erro - Insira um valor Inteiro: ");
                VerIntPos();
                return 0;
            }
         }

        //validação de nota
        private static double ValidaNota()
        {
            double entrada;
            bool sair = false;
            do {
                entrada = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(entrada < 0 || entrada > 10) Console.Write("ERRO - Digite um valor de 0 a 10: ");
                else sair = true;
            } while (!sair);
            return entrada;
        }

    }
}
