using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            int num;
            do {
                Console.WriteLine("Digite um numero maior que zero: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num<=0);
            Console.WriteLine("Acertou!");
            Console.ReadKey();
        }//fim
    }
}
