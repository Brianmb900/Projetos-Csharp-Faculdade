using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_3
{
    class Program
    {
        static void Main(string[] args)
        {//Iníco
            //#Desenvolvedor Brian Melinski Bianchini

            double n, r, q;
            Console.WriteLine("Insira um número para ser feita a raíz quadrada dele e também elevalo ao quadrado");
            n = Convert.ToDouble(Console.ReadLine());
            r = Math.Sqrt(n);
            q = Math.Pow(n, 2);
            Console.WriteLine("A raiz é: " + r);
            Console.WriteLine("O quadrado é: " + q);
            Console.ReadKey();

        }//Fim
    }
}
