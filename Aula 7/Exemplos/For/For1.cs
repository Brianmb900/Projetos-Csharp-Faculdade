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
            int c;
            Console.WriteLine("A sequencia de 0 a 1000");
            for (c = 0; c <= 1000; c++) {
                Console.WriteLine(c);
                Thread.Sleep(100);
            }
            Console.ReadKey();
        }//fim
    }
}
