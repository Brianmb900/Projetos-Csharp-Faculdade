using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("▓       FATEC - 2021        ▓");
            Console.SetCursorPosition(5, 4);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(5, 9);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(7, 5);
            Console.WriteLine("1 - PRIMEIRA");
            Console.SetCursorPosition(7, 6);
            Console.WriteLine("2 - SEGUNDA");
            Console.SetCursorPosition(7, 7);
            Console.WriteLine("3 - TERCEIRA");
            Console.SetCursorPosition(25, 5);
            Console.Write("[ ]");
            Console.SetCursorPosition(26, 5);
            int op = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(25, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            switch (op) {
                case 1:
                    Console.WriteLine("Opção 1");
                    break;
                case 2:
                    Console.WriteLine("Opção 2");
                    break;
                case 3:
                    Console.WriteLine("Opção 3");
                    break;
                default:
                    Console.WriteLine("Nenhuma");
                    break;
             }
            Console.ReadKey();
        }//fim
    }
}
