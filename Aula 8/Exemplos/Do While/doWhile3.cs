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
                Console.Write("Digite a nota de 0 a 10:");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num<0 || num>10);
            Console.WriteLine("Acertou!");
            Console.ReadKey();
        }//fim
    }
}
