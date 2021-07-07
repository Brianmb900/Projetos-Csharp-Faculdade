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
            inicio:
            int num;
            Console.WriteLine("Digite um numero: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero: " + num);
            }
            catch {
                Console.WriteLine("Valor incorreto!");
                goto inicio;
            }

            Console.ReadKey();
        }//fim
    }
}
