using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolvedor Brian Melinski Bianchini

            double tf, tc;
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
            Console.SetCursorPosition(37, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Conversor de Fahrenheit para Celsius");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Insira a temperatura: ");
            tf = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(38, 7);
            tc = (tf -32) * 5/9;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"A temperatura em Celsius é: {tc}");
            Console.ReadKey();  

        }//Fim
    }
}
