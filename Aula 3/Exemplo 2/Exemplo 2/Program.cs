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
            Console.WriteLine("Calculadora de somas de 2 números");//Só write escreve e não pula linha.
            Console.WriteLine("Digite o primerio número");//WriteLine escreve e pula linha.
            n1 = Convert.ToDouble(Console.ReadLine());//Convert é usado para converter o valor para o memso da variável.
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToDouble(Console.ReadLine());//Console ReadLine é usado para ler o valor da linha e então pular uma linha, só read não pula a linha.
            r = n1 + n2;
            Console.WriteLine("O Resultado é: " + r);
            Console.ReadKey();
        }//Fim
    }
}
