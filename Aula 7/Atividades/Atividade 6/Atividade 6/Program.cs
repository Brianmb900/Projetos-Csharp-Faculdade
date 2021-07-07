using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {//Início
         //# Desenvolvedor Brian Melinski Bianchini 03/07/2021

            double n, i, i18;
            n = 1;
            i18 = 0;
            Console.WriteLine("Digite 10 idades");
            while (n <= 10)
            {
                Console.Write($"{n}: ");
               i= Convert.ToDouble(Console.ReadLine());
                n++;
                if (i > 18)
                {
                    i18++;
                }
            }
            Console.WriteLine($"{i18} pessoas tem mais de 18 anos");
            Console.ReadKey();
        }//Fim
    }
}
