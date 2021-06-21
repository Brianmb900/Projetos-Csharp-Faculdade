using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            //# Desenvolvedor Brian Melinski Bianchini 21.06.2021

            string n, ns, e, en;
            int le;
            Console.WriteLine("Digite seu nome completo");
            n = Console.ReadLine();
            le = n.IndexOf(" ");
            ns = n.Substring(0, le);
            e = "nome@fatec.sp.gpv.br";
            ns = ns.ToLower();
            en = e.Replace("nome", ns);
            Console.WriteLine($"Seu e-mail institucional é:{en}");
            Console.ReadLine();
        }//Fim
    }
}
