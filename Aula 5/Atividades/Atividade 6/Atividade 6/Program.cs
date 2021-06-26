using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
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
            Console.SetCursorPosition(37, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Verificar se o número é mutiplo de 5");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite um número: ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n % 5 == 0)
            {
                Console.SetCursorPosition(42, 7);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("O número é mutiplo de 5");
            }
            else
            {
                Console.SetCursorPosition(42, 7);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("O número não é mutiplo de 5");
            }
            Console.ReadKey();

        }//Fim
    }
}
