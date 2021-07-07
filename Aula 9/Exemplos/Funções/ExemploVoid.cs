using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void mold() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            int c = 2;
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            for (c = 3; c <= 8; c++) {
                Console.SetCursorPosition(5, c);
                Console.WriteLine("▒                        ▒");
            }
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }

        static void Main(string[] args)
        {//inicio
            mold();
            Console.ReadKey();
        }//fim
    }
}
