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
            int c = 0;
            Console.WriteLine("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            do {
                int resp = c * num;
                Console.WriteLine(resp);
                c++;// c = c + 1;
            } while (c<=10);
            Console.ReadKey();
        }//fim
    }
}
