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
            Console.WriteLine("Digite um numero par positivo: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if((num>0) && (num % 2 == 0))
            {
                Console.WriteLine("Numero par postivo.");
            }
            Console.ReadKey();
        }//fim
    }
}
