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

            double tc, tk;
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
            Console.SetCursorPosition(39, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Conversor de Celsius para Kelvin");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Insira a temperatura: ");
            tc = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(38, 7);
            tk = tc + 273.15;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"A temperatura em kelvin é: {tk}");
            Console.ReadKey();

        }//Fim
    }
}
