using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_6
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolder Brian Melinski Bianchini

            string t, pt;
            Console.WriteLine("Digite um texto:");
            t = Console.ReadLine();
            pt = t.Substring(1, 5);
            Console.Write("Parte do texto: " + pt);
            Console.ReadKey();

        }//Fim
    }
}
