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
            int[] idades = {10,20,30,40,50,90};
            Console.WriteLine("=================");
            Console.WriteLine(idades[0]);
            Console.WriteLine(idades[1]);
            Console.WriteLine(idades[2]);
            Console.WriteLine(idades[3]);
            Console.WriteLine(idades[4]);
            Console.WriteLine("=================");
            Console.WriteLine("for");
            for (int c = 0; c < 5; c++) {
                Console.WriteLine(idades[c]);
            }
            Console.WriteLine("=================");
            Console.WriteLine("while");
            int i = 0;
            while (i < 5) {
                Console.WriteLine(idades[i]);
                i++;
            }
            Console.WriteLine("=================");
            Console.WriteLine("foreach");
            foreach (int idade in idades) {
                Console.WriteLine(idade);
            }
            Console.ReadKey();
        }//fim
    }
}
