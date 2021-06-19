using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_7
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolder Brian Melinski Bianchini

            string t, ts;
            Console.WriteLine("Digite um texto:");
            t = Console.ReadLine();
            ts = t.Replace("a","o");
            Console.Write("Substituição do a por o: " + ts);
            Console.ReadKey();

        }//Fim
    }
}
