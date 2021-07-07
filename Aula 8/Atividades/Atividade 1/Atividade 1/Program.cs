using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {//Início
         //# Desenvolvedor Brian Melinski Bianchini

            Console.Title = ("Verificar se um número é par");
            int n;
            do
            {
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
                Console.SetCursorPosition(40, 3);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Verificar se o número é par");
                Console.SetCursorPosition(21, 5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Digite um número: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(21, 7);
                if (n % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"O número que você digittou foi: {n}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Digite um número válido");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (n % 2 != 0);

        }//Fim
    }
}
