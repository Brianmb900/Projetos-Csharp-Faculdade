using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Biran Melinski Bianchini

            int a, m, d, id;
            Console.WriteLine("Digite sua idade em anos, mês e dias");
            Console.WriteLine("Digite os anos");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os meses");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os dias");
            d = Convert.ToInt32(Console.ReadLine());
            a = a * 365;
            m = m * 30;
            id = a + m + d;
            Console.WriteLine("Sua idade em dias é: " + id);
            Console.ReadKey();


        }//Fim
    }
}
