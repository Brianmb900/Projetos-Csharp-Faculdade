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
        static int soma(int n1, int n2) {
            int r = n1 + n2;
            return r;
        }

        static void Main(string[] args)
        {//inicio
            Console.Title = "Função";
            mold();
            Console.SetCursorPosition(7, 4);
            Console.Write("Entre com o primeiro valor: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(7, 5);
            Console.Write("Entre com o segundo valor: ");
            int b = Convert.ToInt32(Console.ReadLine());
            //int resultado = soma(a, b);
            Console.SetCursorPosition(7, 6);
            Console.Write("Resultado: "+soma(a,b));
            Console.ReadKey();
        }//fim
    }
}
