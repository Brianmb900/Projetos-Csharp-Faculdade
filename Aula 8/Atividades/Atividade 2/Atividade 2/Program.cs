using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {//Início
         //# Desenvolvedor Brian Melinski Bianchini

            Console.Title = ("Calculadora de Médias");
            double n1, n2, n3, n4, m;
            int o;
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(20, 2);
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
                for (int i = 3; i < 16; i++)
                {
                    Console.SetCursorPosition(20, i);
                    Console.WriteLine("║                                                                      ║");
                }
                Console.SetCursorPosition(20, 16);
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(44, 3);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Calculadora de Médias");
                Console.ForegroundColor = ConsoleColor.Red;
                do
                {
                    Console.SetCursorPosition(21, 5);
                    Console.Write("Digite a 1º nota: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                } while (n1 < 0 || n1 > 10);
                do
                {
                    Console.SetCursorPosition(21, 7);;
                    Console.Write("Digite a 2º nota: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                } while (n2 < 0 || n2 > 10);
                do
                {
                    Console.SetCursorPosition(21, 9);
                    Console.Write("Digite a 3º nota: ");
                    n3 = Convert.ToDouble(Console.ReadLine());
                } while (n3 < 0 || n3 > 10);
                do
                {
                    Console.SetCursorPosition(21, 11);
                    Console.Write("Digite a 4º nota: ");
                    n4 = Convert.ToDouble(Console.ReadLine());
                } while (n4 < 0 || n4 > 10);
                m = (n1 + n2 + n3 + n4) / 4;
                if (m > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.SetCursorPosition(21, 13);
                Console.WriteLine($"A média é: {m}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(21, 15);
                Console.Write("Digite para 1 continuar ou 0 para sair: ");
                o = Convert.ToInt32(Console.ReadLine());
            } while (o == 1);

        }//Fim
    }
}
