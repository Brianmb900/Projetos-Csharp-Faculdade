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

            double vv;
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
            Console.SetCursorPosition(39, 3);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Calculadora de prêmio por vendas");
            Console.SetCursorPosition(21, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Insira o valor das vendas deste mês: ");
            vv = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(38, 7);
            if (vv < 1000)
                { 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Você não ganhou nenhum prêmio T-T");
                }
            else if (vv >= 1000 && vv < 3000)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Você ganhou um prêmio de R$ 150,00 :)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Você ganhou um prêmio de R$ 300,00 !!!");
            }
            Console.ReadKey();

        }//Fim
    }
}
