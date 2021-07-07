using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {//Início
         //# Desenvolvedor Brian Melinski Bianchini 03/07/2021

            double n, i, nn;
            i = 1;
            nn = 0;
            Console.WriteLine("Digite 10 números");
            while (i <= 10)
            {
                Console.Write($"{i}: ");
                n = Convert.ToDouble(Console.ReadLine());
                i++;
                if (n < 0)
                {
                    nn++;
                }
            }
            Console.WriteLine($"{nn} números são negativos");
            Console.ReadKey();
        }//Fim
    }
}
