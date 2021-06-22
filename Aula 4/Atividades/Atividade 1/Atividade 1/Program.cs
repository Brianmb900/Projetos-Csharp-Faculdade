using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolvedor Brian Melinski Bianchini 20.06.2021

            double R, r;
            Console.WriteLine("Programa para calcular a área, diâmetro e perítetro de um círculo.");
            Console.Write("Insira o raio para fazer os calculos: ");
            R = Convert.ToDouble(Console.ReadLine());
            r = Math.PI * Math.Pow(R, 2);
            Console.WriteLine($"O valor da área é: {r}");
            r = 2 * R;
            Console.WriteLine($"O valor do diâmetro é: {r}");
            r = 2 * Math.PI * R;
            Console.WriteLine($"O valor do perímetro é: {r}");
            Console.ReadKey();

        }//Fim
    }
}
