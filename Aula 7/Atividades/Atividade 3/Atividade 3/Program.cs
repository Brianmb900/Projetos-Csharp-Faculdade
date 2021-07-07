using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {//Início
         //# Desenvolvedor Brian Melinski Bianchini 03/07/2021

            double s, n;
            s = 0;
            Console.WriteLine("Digite 10 números");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}º: ");
                n = Convert.ToDouble(Console.ReadLine());
                if (n > 10)
                {
                    s = s + n;
                }
            }
            Console.WriteLine($"Soma: {s}");
            Console.ReadKey();
        }//Fim
    }
}
