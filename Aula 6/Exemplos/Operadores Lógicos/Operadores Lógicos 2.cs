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
            Console.Title = "Operadores Lógicos";
            Console.WriteLine("Digite a nota 1 ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2 ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 3 ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 4 ");
            double num4 = Convert.ToDouble(Console.ReadLine());
            double m = (num1 + num2 + num3 + num4) / 4;
            
            if (m >= 5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(m+" APROVADO");
            }
            else if ((m >= 3) && (m < 5))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(m +" RECUPERAÇÃO");
            }
            else {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(m+" REPROVADO");
            }
            Console.ReadKey();
        }//fim
    }
}
