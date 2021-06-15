using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian Melinski Bianchini 15.06.2021

            double n1, n2, r;
            Console.WriteLine("Calculadora de somas de 2 números");
            Console.WriteLine("Digite o primerio número");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToDouble(Console.ReadLine());
            r = n1 + n2;
            Console.WriteLine("O Resultado é: " + r);
            Console.ReadKey();
        }//FIm
    }
}
