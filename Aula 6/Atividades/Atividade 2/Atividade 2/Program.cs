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
        {
            {//Início
             //# Desenvolvedor Brian Melinski Bianchini

                double n;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(20, 2);
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
                for (int i = 3; i < 8; i++)
                {
                    Console.SetCursorPosition(20, i);
                    Console.WriteLine("║                                                                      ║");
                }
                Console.SetCursorPosition(20, 8);
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(43, 3);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Verificador de números");
                Console.SetCursorPosition(21, 5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Insira um número: ");
                n = Convert.ToDouble(Console.ReadLine());
                if (n % 3 == 0 && n % 7 == 0 )
                {
                    Console.SetCursorPosition(44, 7);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Múltiplo de 3 e 7");
                }
                else
                {
                    Console.SetCursorPosition(47, 7);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Não é múltiplo");
                }
                Console.ReadKey();

            }//Fim
        }
    }
}
