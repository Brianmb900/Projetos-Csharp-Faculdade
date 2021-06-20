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
            int o, d;
            Console.WriteLine("Calculadora V1.0");
            do
            {
                Console.WriteLine("Digite 1-Soma, 2-Subtração, 3-Multiplicação, 4-Divisão");
                o = Convert.ToInt32(Console.ReadLine());
                switch (o)
                {
                    case 1:
                        Console.WriteLine("Digite 2 números para somar");
                        Console.Write("Digite o 1º: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o 2º: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        rso = n1 + n2;
                        Console.WriteLine("O resultado da soma é: " + rso);
                        break;

                    case 2:
                        Console.WriteLine("Digite 2 números para subtrair");
                        Console.Write("Digite o 1º: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o 2º: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        rsu = n1 - n2;
                        Console.WriteLine("O resultado da soma é: " + rsu);
                        break;

                    case 3:
                        Console.WriteLine("Digite 2 números para multiplicar");
                        Console.Write("Digite o 1º:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o 2º: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        rm = n1 * n2;
                        Console.WriteLine("O resultado da soma é: " + rm);
                        break;

                    case 4:
                        Console.WriteLine("Digite 2 números para dividir");
                        Console.Write("Digite o 1º: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o 2º:");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        rd = n1 / n2;
                        Console.WriteLine("O resultado da soma é: " + rd);
                        break;
                }
                Console.WriteLine("Para continuar usando a calculadora digite 1, para sair digite 0");
                d = Convert.ToInt32(Console.ReadLine());
            }
            while (d == 1);
        }//Fim
    }
}
