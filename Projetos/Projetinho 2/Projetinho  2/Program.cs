using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho__2
{
    class Program
    {
        static void Main(string[] args)
        {//Iníco
            //#Desenvolvedor Brian Melinski Bianchini 15.06.2021

            double[] teste = new double[100];
            for (int i = 0; i <= 99; i++)
            {
                Console.WriteLine(String.Format("Informe o elemento de índice {0}:", i));
                teste[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(teste[i]);
            }

        }//Fim
    }
}
