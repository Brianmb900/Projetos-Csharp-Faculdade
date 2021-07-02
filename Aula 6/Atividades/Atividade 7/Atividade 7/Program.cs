using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian Melinski Bianchini 02.07.2021

            int o, d;
            double s, sa, ds;
            Console.Title = ("Calculadora de Aumentos");

            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                for (int i = 3; i < 16; i++)
                {
                    Console.SetCursorPosition(10, i);
                    Console.WriteLine("║                                                                                                    ║");
                }
                Console.SetCursorPosition(10, 16);
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(47, 3);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Calculadora de Aumentos");
                Console.SetCursorPosition(11, 5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1-Gerente, 2-Analista, 3-Técnico, 4-Não está na lista");
                Console.SetCursorPosition(66, 5);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(67, 5);
                o = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(11, 7);
                switch (o)
                {
                    case 1:
                        Console.Write("Insira o salário: ");
                        s = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Você terá um aumetno de 10%");
                        sa = Math.Round(s + (s * 0.10), 2);
                        ds = sa - s;
                        Console.SetCursorPosition(11, 11);
                        Console.Write($"A diferença entre seu novo saláraio e o antiog é {ds} ");
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine($"Seu salário novo é {sa}");
                        break;

                    case 2:
                        Console.Write("Insira o salário: ");
                        s = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Você terá um aumetno de 20%");
                        sa = Math.Round(s + (s * 0.20),2);
                        ds = sa - s;
                        Console.SetCursorPosition(11, 11);
                        Console.Write($"A diferença entre seu novo saláraio e o antiog é {ds} ");
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine($"Seu salário novo é {sa}");
                        break;

                    case 3:
                        Console.Write("Insira o salário: ");
                        s = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Você terá um aumetno de 30%");
                        sa = Math.Round(s + (s * 0.30), 2);
                        ds = sa - s;
                        Console.SetCursorPosition(11, 11);
                        Console.Write($"A diferença entre seu novo saláraio e o antiog é {ds} ");
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine($"Seu salário novo é {sa}");
                        break;

                    case 4:
                        Console.Write("Insira o salário: ");
                        s = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Você terá um aumetno de 40%");
                        sa = Math.Round(s + (s * 0.40), 2);
                        ds = sa - s;
                        Console.SetCursorPosition(11, 11);
                        Console.Write($"A diferença entre seu novo saláraio e o antiog é {ds} ");
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine($"Seu salário novo é {sa}");
                        break;
                }
                Console.SetCursorPosition(11, 15);
                Console.WriteLine("Para continuar e ver outro aumento digite 1, para sair digite 0");
                Console.SetCursorPosition(75, 15);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(76, 15);
                d = Convert.ToInt32(Console.ReadLine());
            }
            while (d == 1);
        }//Fim
    }
    }
