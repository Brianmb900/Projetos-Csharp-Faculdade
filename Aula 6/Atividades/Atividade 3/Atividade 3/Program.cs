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
            Console.Title = ("Calculadora de Descontos");

            string n, de;
            double qtd, pu, d, t, tp;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
            for (int i = 3; i < 14; i++)
            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine("║                                                                      ║");
            }
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(44, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Calculadora de Descontos");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Insira o nome do produto: ");
            n = Console.ReadLine();
            Console.SetCursorPosition(21, 7);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Insira a qunatidade comprada: ");
            qtd = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(21, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insira o preço unitário: ");
            pu = Convert.ToDouble(Console.ReadLine());
            if (qtd <= 5)
            {
                d = 0.02;
                de = "2%";
            }
            else if (qtd > 5 && qtd <= 10)
            {
                d = 0.03;
                de = "3%";
            }
            else
            {
                d = 0.05;
                de = "5%";
            }
            t = Math.Round((qtd * pu),2);
            tp = Math.Round((t - (t * d)),2);
            Console.SetCursorPosition(21, 11);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"O total da sua compra é: {t} e você obeteve {de} de desconto" );
            Console.SetCursorPosition(21, 13);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"O total a pagar é: {tp}");
            Console.ReadKey();

        }//Fim
    }
}
