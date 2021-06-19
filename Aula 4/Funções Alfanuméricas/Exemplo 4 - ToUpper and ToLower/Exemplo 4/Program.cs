using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_4
{
    class Program
    {
        static void Main(string[] args)
        {//Início 
            //# Desenvolveor Brian Melinski Bianchini

            string n, nma, nmi;
            Console.WriteLine("Digite seu nome");
            n = Console.ReadLine();
            nma = n.ToUpper();
            nmi = n.ToLower();
            Console.WriteLine("Seu nome em maíusculo: " + nma + ". Seu nome em minúsculo: " + nmi);
            Console.ReadKey();

        }
    }//Fim
}
