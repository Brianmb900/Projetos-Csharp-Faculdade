using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolvedor Brian Melinski Bianchini

            double s30, s, p;
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
            Console.SetCursorPosition(42, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Verificadora de Empréstimos");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite seu salário: ");
            s = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(21, 7);
            Console.Write("Digite o valor da prestação: ");
            p = Convert.ToDouble(Console.ReadLine());
            s30 = s * 0.3;
            if (p <= s30)
            {
                Console.SetCursorPosition(40, 9);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Você pode fazer o empréstimo");
            }
            else
            {
                Console.SetCursorPosition(40, 9);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Você não pode fazer o empréstimo");
            }
            Console.ReadKey();

        }//Fim
    }
}
