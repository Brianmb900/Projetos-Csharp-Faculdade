using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhando_com_Layout_e_Cor
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolvedor Biran Melinski Bianchini

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("║                                   ║");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(12, 3);
            Console.WriteLine("FATEC 2021 - ADS");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(4, 5);
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.SetCursorPosition(4, 7);
            Console.Write("Bem vindo, ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(nome);
            Console.ReadKey();

        }//Fim
    }
}
