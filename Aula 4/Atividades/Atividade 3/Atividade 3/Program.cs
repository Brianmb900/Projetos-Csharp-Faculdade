using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolvedor Brian Melinski Bianchini 20.06.2021

            string n, pn, ao, ns, s;
            int le, le2, l1, lc, u;
            Console.WriteLine("Digite seu nome completo");
            n = Console.ReadLine();
            pn = n.Substring(5,6);// A função substring corta um pedaço da string começando em um caractere específico, e vai até x-1 caracteres adiante. Exemplo: paralelepipedo SubString(2,3) = ral caracatere inicial 2 = r até 3-1 =l resultando no ral.
            ao = n.Replace("a", "o");
            le = n.IndexOf(" ");
            le2 = n.LastIndexOf(" ");
            l1 = (le2 + 1);
            u = n.Length;
            lc = ((u - le2) - 1);
            ns = n.Substring(0,le);
            s = n.Substring(l1,lc);
            Console.WriteLine($"Nome:{ns}");
            Console.WriteLine($"Sobrenome:{s}");
            Console.WriteLine($"O pedaço do nome do caractere 5 ao 10 é:{pn}");
            Console.WriteLine($"A substituição de a por o é:{ao}");
            Console.ReadKey();

            //Versão do professor
            /*
            string completo, sobrenome, nome, parte, troca, email;
            Console.WriteLine("Entrar com o nome completo: ");
            completo = Console.ReadLine();
            Console.WriteLine("Nome completo: " + completo);
            int pos = completo.IndexOff(" ");
            Console.WriteLine("Posição espaço: " + pos);
            nome = completo.Substring(0,pos);
            sobrenome = completo.Substring(pos);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            parte = completo.Substring(5,10);
            Console.WriteLine("Corte: " + parte);
            troca = completo.Replace("a","o");
            Console.WriteLine("Troca: " + troca);
            email = nome + "@fatec.sp.gov.br";
            Console.WriteLine("Email: " + email);
            Console.ReadKey();
            */
        }//Fim
    }
}
