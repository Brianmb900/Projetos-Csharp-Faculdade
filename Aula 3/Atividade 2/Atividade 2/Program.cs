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

            double n1, n2, r;//Colocar os resultados em uma única variável para o programa ficar mais leve
            Console.WriteLine("Digite dois números para serem somados, subtraidos, multiplicados e divididos");
            Console.WriteLine("1º Num.");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2º Num.");
            n2 = Convert.ToDouble(Console.ReadLine());
            r = n1 + n2;
            Console.WriteLine("O resultado da soma é: " + r);
            r = n1 - n2;
            Console.WriteLine("O resultado da subtração é: " + r);
            r = n1 * n2;
            Console.WriteLine("O resultado da multiplicação é: " + r);
            r = n1 / n2;
            Console.WriteLine("O resultado da divisão é: " + r);
            Console.ReadKey();

        }//Fim
    }
}
