using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
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
            Console.WriteLine("Verificar se o número é maior que 20");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite um número: ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n > 20)
            {
                n = n / 2;
                Console.SetCursorPosition(42, 7);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"A metade do número é: {n}");
            }
            else
            {
                n = n * 2;
                Console.SetCursorPosition(42, 7);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"O dobro do número é: {n}");
            }
            Console.ReadKey();

        }//Fim
    }
}
