using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Moldura()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════╗");
            for (int i = 3; i < 14; i++)
            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine("║                                                                                            ║");
            }
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        static int Triangulo(int n1, int n2, int n3)
        {
            double s1, s2, s3;
            s1 = n1 + n2;
            s2 = n1 + n3;
            s3 = n2 + n3;
            if (s1 > n3 || s2 >n3 || s3 > n1 || s3 > n2)
            {
             Console.WriteLine("Isto é um triângulo");
            }
            return 0;
        }
        static void Main(string[] args)
        {//Início
         //# Desenvolvedor Brian Melinski Bianchini

            Console.Title = ("Verificar se é um triângulo");
            int r1, r2, r3, o;
            do
            {
                Moldura();
                Console.SetCursorPosition(43, 3);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Verificar se é um triângulo");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(21, 5);
                Console.Write("Digite a 1º reta: ");
                r1 = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(21, 7);
                Console.Write("Digite a 2º reta: ");
                r2 = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(21, 9);
                Console.Write("Digite a 3º reta: ");
                r3 = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(21, 11);
                Triangulo(r1,r2,r3);
                Console.SetCursorPosition(21, 13);
                Console.Write("Digite 1 para continuar ou 0 para sair: ");
                o = Convert.ToInt32(Console.ReadLine());
            } while (o == 1);

        }//Fim
    }
}
