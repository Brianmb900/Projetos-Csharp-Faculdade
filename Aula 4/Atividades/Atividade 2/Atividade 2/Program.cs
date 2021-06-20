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
            //# Desenvolvedor Brian Melinski Bianchini 20.06.2021
            double a, b, c, d, x1, x2;
            Console.WriteLine("Programa para calcular uma equação de 2º grau pela fórmula de Bhaskara ");
            Console.Write("Insira o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());
            d = Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c));
            x1 = ((-1 * b) + d) / (2 * a);
            x2 = ((-1 * b) - d) / (2 * a);
            Console.WriteLine($"Os valores de x1 e x2 são: {x1} e {x2}");
            Console.ReadKey();

        }//Fim
    }
}
