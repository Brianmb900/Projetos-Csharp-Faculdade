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
         //# Desenvolvedor Brian Melinski Bianchini 03/07/2021

            double ma, me, n;
            me = 0;
            ma = 0;
            Console.WriteLine("Digite 20 números");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i}º: ");
                n = Convert.ToDouble(Console.ReadLine());
                if (i == 0)
                {
                    me = n;
                    ma = n;
                }
                if (n < me)
                {
                    me = n;
                }
                if (n > ma)
                {
                    ma = n;
                }
            }
            Console.WriteLine($"Maior número: {ma}");
            Console.WriteLine($"Menor número: {me}");
            Console.ReadKey();
        }//Fim
    }
}
