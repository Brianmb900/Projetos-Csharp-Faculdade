using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //#Desenvolvedor Brian Melinski Bianchini 02.07.2021

            int o, d;

            Console.Title = ("Calculadora de Fórmulas");

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
                Console.WriteLine("Calculadora de Fórmulas");
                Console.SetCursorPosition(11, 5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite 1-Bhaskara, 2-Força, 3-Velocidade");
                Console.SetCursorPosition(53, 5);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(54, 5);
                o = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(11, 7);
                switch (o)
                {
                    case 1:
                        double a, b, c, delta, x1, x2;
                        Console.Write("Insira o valor de a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Insira o valor de b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 11);
                        Console.Write("Insira o valor de c: ");
                        c = Convert.ToDouble(Console.ReadLine());
                        delta = Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c));
                        x1 = (-b + delta) / (2 * a);
                        x2 = (-b - delta) / (2 * a);
                        Console.SetCursorPosition(11, 13);
                        Console.WriteLine($"Os valores de x1 e x2 são: {x1} e {x2}");
                        break;

                    case 2:
                        double F, m, ac;
                        Console.Write("Insira o valor da massa: ");
                        m = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Insira o valor da aceleração: ");
                        ac = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 13);
                        F = Math.Round((m * ac), 2);
                        Console.Write($"O valor da força é: {F}");
                        break;

                    case 3:
                        double V, Vo, T;
                        Console.Write("Insira o valor de Vo: ");
                        Vo = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 9);
                        Console.Write("Insira o valor da aceleração: ");
                        ac = Convert.ToDouble(Console.ReadLine());
                        Console.SetCursorPosition(11, 11);
                        Console.Write("Insira o valor do tempo: ");
                        T = Convert.ToDouble(Console.ReadLine());
                        V = Vo + (ac*T);
                        Console.SetCursorPosition(11, 13);
                        Console.Write($"Insira o valor da Velociade é: {V}");
                        break;
                }
                Console.SetCursorPosition(11, 15);
                Console.WriteLine("Para continuar usando a calculadora digite 1, para sair digite 0");
                Console.SetCursorPosition(78, 15);
                Console.WriteLine("[ ]");
                Console.SetCursorPosition(79, 15);
                d = Convert.ToInt32(Console.ReadLine());
            }
            while (d == 1);
        }//Fim
    }
}
