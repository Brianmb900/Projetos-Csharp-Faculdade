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
            //# Desenvolvedor Brian Melinski Bianchini 20.06.2021

            string n, pn, ao, ns;
            Console.WriteLine("Digite seu nome completo");
            n = Console.ReadLine();
            pn = n.Substring(5,6);
            ao = n.Replace("a", "o");
            Console.Write($"Nome e sobrenome separado: ");
            Console.WriteLine($"O pedaço do nome do caractere 5 ao 10 é: {pn}");
            Console.WriteLine($"A substituição de a por o é: {ao}");
            Console.ReadLine();

        }//Fim
    }
}
