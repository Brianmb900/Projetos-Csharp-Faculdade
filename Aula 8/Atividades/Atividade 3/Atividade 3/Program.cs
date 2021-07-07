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

            Console.Title = ("Leitora de números");
            double n;
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(20, 2);
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
                for (int i = 3; i < 6; i++)
                {
                    Console.SetCursorPosition(20, i);
                    Console.WriteLine("║                                                                      ║");
                }
                Console.SetCursorPosition(20, 6);
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(44, 3);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Leitora de números");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(21, 5);
                Console.Write("Digite um número: ");
                n = Convert.ToDouble(Console.ReadLine());
            } while (n > 1);

        }//Fim
    }
}
