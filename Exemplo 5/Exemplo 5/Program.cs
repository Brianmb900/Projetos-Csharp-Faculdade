using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_5
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolder Brian Melinski Bianchini

            string t;
            int pos;
            Console.WriteLine("Digite um texto:");
            t = Console.ReadLine();
            pos = t.IndexOf("a");
            Console.Write("A posição de a é: " + pos);
            Console.ReadKey();

        }//Fim
    }
}
