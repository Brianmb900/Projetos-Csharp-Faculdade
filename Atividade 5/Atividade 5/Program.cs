using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian Melinski Bianchini 15.06.2021

            int a, b;
            Console.WriteLine("Digite um número inteiro para seu antecessor ser exibido");
            a = Convert.ToInt32(Console.ReadLine());
            b = a - 1;
            Console.WriteLine("O antecessor é: " + b);
            Console.ReadKey();

        }//Fim
    }
}
