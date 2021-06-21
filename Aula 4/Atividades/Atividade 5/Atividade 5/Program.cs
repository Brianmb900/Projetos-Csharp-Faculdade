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
            //# Desenvolvedor Brian Melinski Bianchini 20.06.2021
            string n, ns, s, e, ens;
            int le, le2, l1, lc, u;
            Console.WriteLine("Digite seu nome completo");
            n = Console.ReadLine();
            le = n.IndexOf(" ");
            le2 = n.LastIndexOf(" ");
            l1 = (le2 + 1);
            u = n.Length;
            lc = ((u - le2) - 1);
            ns = n.Substring(0, le);
            s = n.Substring(l1, lc);
            e = "nome.ultimosobrenome@fatec.sp.gov.br";
            ns = ns.ToLower();
            s = s.ToLower();
            ens = e.Replace("ultimosobrenome", s);
            ens = ens.Replace("nome", ns);
            Console.WriteLine($"Seu e-mail institucional é:{ens}");
            Console.ReadLine();
        }//Fim
    }
}
