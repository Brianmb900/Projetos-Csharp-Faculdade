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
            string[] nomes = {"Pedro","Yuri","Yohan","André","Gilmar"};
            foreach (string nome in nomes) {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }//fim
    }
}
