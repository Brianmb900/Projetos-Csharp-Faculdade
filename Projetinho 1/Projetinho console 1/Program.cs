using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho_console_1
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian Melinski Bianchini 15.06.2021

            double n1, n2, rso, rsu, rm, rd;
            Int16 o;
            Console.WriteLine("Calculadora V1.0");
            Console.WriteLine("Digite 1-Soma, 2-Subtração, 3-Multiplicação, 4-Divisão");
            o = Convert.ToInt16(Console.ReadLine());
            switch (o)
            {
                case 1:
                    Console.WriteLine("Digite 2 números para somar");
                    Console.WriteLine("Digite o 1º");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o 2º");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    rso = n1 + n2;
                    Console.WriteLine("O resultado da soma é: " + rso);
                    break;
            }
            Console.ReadKey();
        }//Fim
    }
}
