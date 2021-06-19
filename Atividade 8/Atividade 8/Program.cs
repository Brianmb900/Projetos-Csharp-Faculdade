using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_8
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian Melinski Bianchini 15.06.2021

            double n1, n2, n3, m;
            Console.WriteLine("Digite as notas do aluno para calcular a média");
            Console.WriteLine("1º Nota");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ª Nota");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3º Nota");
            n3 = Convert.ToDouble(Console.ReadLine());
            n1 = n1 * 2;
            n2 = n2 * 3;
            n3 = n3 * 5;
            m = (n1 + n2 + n3) / 10;
            Console.WriteLine("A média do aluno é: " + m);
            Console.ReadKey();

        }//Fim
    }
}
