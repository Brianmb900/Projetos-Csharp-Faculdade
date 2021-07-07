using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            double num, soma, med;
            Console.WriteLine("Digite dez numeros: ");
            soma = 0;
            for (int c = 1; c <= 10; c++) {
                Console.Write("Digite o " + c + "º: ");
                num = Convert.ToDouble(Console.ReadLine());
                soma = soma + num;
            }
            med = soma / 10;
            Console.WriteLine("A Soma: " + soma);
            Console.WriteLine("A media é: " + med);
            Console.ReadKey();
        }//fim
    }
}
