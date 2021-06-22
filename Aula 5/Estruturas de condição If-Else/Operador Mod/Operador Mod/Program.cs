using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_Mod
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            //# Desenvolvedor Brian Melinski Bianchini

            Console.Title = "Exemplos Labo";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(12, 3);
            Console.WriteLine("FATEC 2021 - ADS");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(4, 5);
            Console.Write("Insira um número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(14, 8);
            if (n1 % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("PAR");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("IMPAR");
            }
            Console.ReadKey();

        }//Fim
    }
}
