using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian Melinski Bianchini 15.06.2021

            double n1, n2, n3, m;
            Console.WriteLine("Insira 3 números para calcular a média deles");
            Console.WriteLine("1º Num.");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2º Num.");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3º Num.");
            n3 = Convert.ToDouble(Console.ReadLine());
            m = (n1 + n2 + n3) / 3;
            Console.WriteLine("A média é: " + m);
            Console.ReadKey();
            
        }//Fim
    }
}
