using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        static void Moldura()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════╗");
            for (int i = 3; i < 14; i++)
            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine("║                                                                                            ║");
            }
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        static double Soma (double n1, double n2)
        {
            double r = n1 + n2;
            return r;
        }
        static double Subtração(double n1, double n2)
        {
            double r = n1 - n2;
            return r;
        }
        static double Multiplicação(double n1, double n2)
        {
            double r = n1 * n2;
            return r;
        }
        static double Divisão(double n1, double n2)
        {
            double r = n1 / n2;
            return r;
        }
        static void Main(string[] args)
        {//Início
         //# Desenvolvedor Brian Melinski Bianchini

            Console.Title = ("Calculadora");
            double n1, n2;
            int op, o;
            do
            {
                Moldura();   
                Console.SetCursorPosition(50, 3);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Calculadora");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(21, 5);
                Console.WriteLine("Digite 1 para somar, 2 para subtrair, 3 para multiplicar ou 4 para dividir");
                Console.SetCursorPosition(97, 5);
                Console.Write("[ ]");
                Console.SetCursorPosition(98, 5);
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.SetCursorPosition(21, 7);
                        Console.Write("Digite o 1º número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(21, 9);
                        Console.Write("Digite o 2º número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(21, 11);
                        Console.WriteLine("O resultado da soma é: " + Soma(n1, n2));
                        break;
                    case 2:
                        Console.SetCursorPosition(21, 7);
                        Console.Write("Digite o 1º número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(21, 9);
                        Console.Write("Digite o 2º número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(21, 11);
                        Console.WriteLine("O resultado da subtração: " + Subtração(n1, n2));
                        break;
                    case 3:
                        Console.SetCursorPosition(21, 7);
                        Console.Write("Digite o 1º número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(21, 9);
                        Console.Write("Digite o 2º número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(21, 11);
                        Console.WriteLine("O resultado da multiplicação é: " + Multiplicação(n1, n2));
                        break;
                    case 4:
                        Console.SetCursorPosition(21, 7);
                        Console.Write("Digite o 1º número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(21, 9);
                        Console.Write("Digite o 2º número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(21, 11);
                        Console.WriteLine("O resultado da divisão é: " + Divisão(n1, n2));
                        break;
                }
                Console.SetCursorPosition(21, 13);
                Console.Write("Digite 1 para continuar ou 0 para sair: ");
                o = Convert.ToInt32(Console.ReadLine());
            } while (o == 1);

        }//Fim
    }
}
