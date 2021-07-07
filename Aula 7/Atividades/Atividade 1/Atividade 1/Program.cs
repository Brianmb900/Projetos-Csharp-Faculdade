using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolvedor Brian Melinski Bianchini 03/07/2021

            Console.Write("Digite um número para fazer a tabuada dele: ");
            Double n = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
             Double  t = n * i;
                Console.WriteLine($"{t}");
            }

            Console.ReadKey();
        }//Fim
    }
}
