using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutra_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            //# Desenvolvedor Brian Melinski Bianchini 22.06.2021
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
            Console.WriteLine("Entre com as 2 notas: ");
            Console.SetCursorPosition(4, 6);
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(4, 7);
            double n2 = Convert.ToDouble(Console.ReadLine());
            double m = (n1 + n2) / 2;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Resultado: " + m);
            Console.SetCursorPosition(14, 8);
            if (m >= 6)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("REPROVADO");
            }
            Console.ReadKey();

        }//fim
    }
}
