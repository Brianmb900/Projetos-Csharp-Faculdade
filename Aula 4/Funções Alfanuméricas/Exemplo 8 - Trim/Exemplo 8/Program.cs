using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_8
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolder Brian Melinski Bianchini

            string t, tse;
            Console.WriteLine("Digite um texto:");
            t = Console.ReadLine();
            tse = t.Trim();
            Console.Write("O texto sem espaço no começo e no fim é: " + tse);
            Console.ReadKey();

        }//Fim
    }
}
