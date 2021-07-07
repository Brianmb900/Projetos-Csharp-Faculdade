using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
            {//Início
             //# Desenvolvedor Brian Melinski Bianchini 03/07/2021

                Console.Write("Digite um número: ");
                Double n = Convert.ToDouble(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.ReadKey();

        }//Fim
        }
}
