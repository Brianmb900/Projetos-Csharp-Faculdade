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

            double sm, s, qsm;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
            for (int i =3; i < 10; i++)
            {
            Console.SetCursorPosition(20, i);
            Console.WriteLine("║                                                                      ║");
            }
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(44, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Contador de salários mínimos");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Insira o valor do salário mínimo: ");
            sm = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(21, 7);
            Console.Write("Insira o seu salário: ");
            s = Convert.ToDouble(Console.ReadLine());
            qsm = s / sm;
            qsm = Math.Round(qsm,2);
            Console.SetCursorPosition(40, 9);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Você ganha {qsm} salários mínimos");
            Console.ReadKey();

        }//Fim
    }
}
