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
            int num, c, resp;
            c = 0;
            Console.Write("Digite o numero da tabuada: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (c <= 10) {
                resp = c * num;
                Console.WriteLine(num + " x " + c + " = " +resp);
                Thread.Sleep(1000);
                c = c + 1;
            }
            Console.ReadKey();
        }//fim
    }
}
