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
            Console.Title = ("Calculadora de Médias");

            double AP, TP, P, M;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
            for (int i = 3; i < 12; i++)
            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine("║                                                                      ║");
            }
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(46, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Calculadora de Médias");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Insira a Nota de AP: ");
            AP = Convert.ToDouble(Console.ReadLine());
            AP = AP * 0.25;
            Console.SetCursorPosition(21, 7);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Insira a Nota de TP: ");
            TP = Convert.ToDouble(Console.ReadLine());
            TP = TP * 0.25;
            Console.SetCursorPosition(21, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insira a Nota de P: ");
            P = Convert.ToDouble(Console.ReadLine());
            P = P * 0.5;
            M = Math.Round((AP + TP + P),1);
            Console.SetCursorPosition(21, 11);
            if (M >= 9)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Conceito do aluno: A");
            }
            else if (M >= 7.5 && M < 9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Conceito do aluno: B");
            }
            else if (M >= 6 && M < 7.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Conceito do aluno: C");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Conceito do aluno: D");
            }
            Console.ReadKey();

        }//Fim
    }
}
