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

            int num;
            Console.WriteLine("Digite um numero: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero: " + num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor incorreto!");
                Console.WriteLine(ex);

            }
            finally {
                Console.WriteLine("FACULDADE FATEC - 2021");
            }
            Console.ReadKey();
        }//fim
    }
}
