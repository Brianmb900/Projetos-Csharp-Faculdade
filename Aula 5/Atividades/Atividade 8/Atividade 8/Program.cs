using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_8
{
    class Program
    {
        static void Main(string[] args)
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
            Console.SetCursorPosition(45, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Verificadora de Números");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite um número: ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n == 0)
            {
                Console.SetCursorPosition(48, 7);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("O seu número é 0");
            }
            else if (n > 0)
            {
                Console.SetCursorPosition(46, 7);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Seu número é positivo");
            }
            else
            {
                Console.SetCursorPosition(46, 7);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Seu número é negativo");
            }
            Console.ReadKey();

        }//Fim
    }
}
