using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian melinski BIanchini 15.06.2021

            double a, b, h;
            Console.WriteLine("Calculadora de área de retângulos regulares");
            Console.WriteLine("Digite a base");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            h = Convert.ToDouble(Console.ReadLine());
            a = b * h;
            Console.WriteLine("A área do retângulo é: " + a);
            Console.ReadKey();

        }//Fim
    }
}
