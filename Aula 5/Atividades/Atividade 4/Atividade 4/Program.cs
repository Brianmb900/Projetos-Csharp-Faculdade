using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolvedor Brian Melinski Bianchini

            double pk, pg, pk10;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
            for (int i = 3; i < 10; i++)
            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine("║                                                                      ║");
            }
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(47, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Conversor de Peso");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Insira o peso em kilos: ");
            pk = Convert.ToDouble(Console.ReadLine());
            pk10 = pk + (pk * 0.1);
            pg = pk * 1000;
            Console.SetCursorPosition(42, 7);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Seu peso em gramas é: {pg}");
            Console.SetCursorPosition(38, 9);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Seu peso com acrescimo de 10%: {pk10}");
            Console.ReadKey();

        }//Fim
    }
}
