using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian Melinski Bianchini 02.07.2021

            double n1, n2, rso, rsu, rm, rd, rq, p;
            int o, d;

            Console.Title = ("Calculadora V1.5");
            
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                for (int i = 3; i < 16; i++)
                {
                    Console.SetCursorPosition(10, i);
                Console.WriteLine("║                                                                                                    ║");
                }
                Console.SetCursorPosition(10, 16);
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(53, 3);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Calculadora V1.5");
                Console.SetCursorPosition(11, 5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite 1-Soma, 2-Subtração, 3-Multiplicação, 4-Divisão, 5 Raiz Qudarada, 6 Potênciação");
                Console.SetCursorPosition(105, 5);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(106, 5);
                o = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(11, 7);
                switch (o)
                {
                    case 1:
                        Console.WriteLine("Digite 2 números para somar");
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Digite o 1º: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 11);
                        Console.Write("Digite o 2º: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        rso = n1 + n2;
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine("O resultado da soma é: " + rso);
                        break;

                    case 2:
                        Console.WriteLine("Digite 2 números para subtrair");
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Digite o 1º: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 11);
                        Console.Write("Digite o 2º: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        rsu = n1 - n2;
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine("O resultado da soma é: " + rsu);
                        break;

                    case 3:
                        Console.WriteLine("Digite 2 números para multiplicar");
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Digite o 1º:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 11);
                        Console.Write("Digite o 2º: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        rm = n1 * n2;
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine("O resultado da subtração é: " + rm);
                        break;

                    case 4:
                        Console.WriteLine("Digite 2 números para dividir");
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Digite o 1º: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 11);
                        Console.Write("Digite o 2º:");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        rd = n1 / n2;
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine("O resultado da divisão é: " + rd);
                        break;
                    case 5:
                        Console.WriteLine("Digite 1 número par fazer sua raiz quadrada");
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Digite o número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        rq = Math.Round(Math.Sqrt(n1),2);
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine("O resultado da raiz é: " + rq);
                        break;
                    case 6:
                        Console.WriteLine("Digite as informações para fazer a potênciação");
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Digite a base: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 11);
                        Console.Write("Digite o expoente: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        p = Math.Round(Math.Pow(n1,n2));
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine("O resultado da potênciação: " + p);
                        break;
                }
                Console.SetCursorPosition(11, 15);
                Console.WriteLine("Para continuar usando a calculadora digite 1, para sair digite 0");
                Console.SetCursorPosition(78, 15);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(79, 15);
                d = Convert.ToInt32(Console.ReadLine());
            }
            while (d == 1);
        }//Fim
    }
}
