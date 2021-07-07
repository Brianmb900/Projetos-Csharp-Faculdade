using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {//Início
         //# Desenvolvedor Brian Melinski Bianchini 03/07/2021

            double ni, nf, n;
            Console.WriteLine("Digite 2 números um como início da sequência e outro como o final");
            Console.Write("Início: ");
            ni = Convert.ToDouble(Console.ReadLine());
            n = ni;
            Console.Write("Final: ");
            nf = Convert.ToDouble(Console.ReadLine());
            while (n <= nf)
            {
                Console.WriteLine($"{n}");
                n++;
            }
            Console.ReadKey();
        }//Fim
    }
}
