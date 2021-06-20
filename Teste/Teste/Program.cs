using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {//Iníco
            //#Desenvovledor

            double []  n = new double [10];
            for (int i = 0; i <=9; i++) 
            {
                Console.Write("Escreva um número: ");
                n[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Numeros escritos: " + n [i]);
            }
            Console.ReadKey();

        }//Fim
    }
}
