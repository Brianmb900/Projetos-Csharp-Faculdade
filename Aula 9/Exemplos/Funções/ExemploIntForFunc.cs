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
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            for (c = 3; c <= 15; c++) {
                Console.SetCursorPosition(5, c);
                Console.WriteLine("▒                                    ▒");
            }
            Console.SetCursorPosition(5, c);
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }
        static int tab(int n1, int n2) {
            for (int c = 0; c <= n2; c++) {
                int r = n1 * c;
                Console.SetCursorPosition(7, c + 6);
                Console.WriteLine(n1 + " x " + c + " = " + r);

            }
            return 0;
        }

        static void Main(string[] args)
        {//inicio
            Console.Title = "Função";
            mold();
            Console.SetCursorPosition(7, 4);
            Console.Write("Entre o valor da tabuada: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(7, 5);
            Console.Write("Tabuada até qual numero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            tab(a, b);
            Console.ReadKey();
        }//fim
    }
}
