using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian Melinski Bianchini 15.06.2021

            int ad, at, i;
            Console.WriteLine("Digite o ano em que você nasceu e o ano autal para calcular sua idade");
            Console.WriteLine("Digite seu ano de nascimento");
            ad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano atual");
            at = Convert.ToInt32(Console.ReadLine());
            i = at - ad;
            Console.Write("Sua idade é " + i);
            Console.WriteLine(" anos");
            Console.ReadKey();

        }//Fim
    }
}
