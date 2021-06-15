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
            //#Desenvolvedor Brian Melinski Bianchini 15.06.2021

            double n1, n2, rso, rsu, rsm, rsd;
            Console.WriteLine("Digite dois números para serem somados, subtraidos, multiplicados e divididos");
            Console.WriteLine("1º Num.");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2º Num.");
            n2 = Convert.ToDouble(Console.ReadLine());
            rso = n1 + n2;
            rsu = n1 - n2;
            rsm = n1 * n2;
            rsd = n1 / n2;
            Console.WriteLine("O resultado da soma é: " + rso);
            Console.WriteLine("O resultado da subtração é: " + rsu);
            Console.WriteLine("O resultado da multiplicação é: " + rsm);
            Console.WriteLine("O resultado da divisão é: " + rsd);
            Console.ReadKey();

        }//Fim
    }
}
