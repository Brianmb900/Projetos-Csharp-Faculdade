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
        static double tempM(double n1, double n2) {
            double r = (n1 + n2)/2;
            return r;
        }

        static void Main(string[] args)
        {//inicio
            Console.Title = "Função";
            mold();
            Console.SetCursorPosition(7, 4);
            Console.Write("Entre com a temperatura 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(7, 5);
            Console.Write("Entre com a temperatura 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(7, 6);
            Console.Write("Resultado: "+tempM(a,b));
            Console.ReadKey();
        }//fim
    }
}
