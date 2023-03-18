using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaVetor
{
    public class Cliente
    {

        public string Nome { get; set; }    
        public string Cpf { get; set; }
        public string Rg { get; set; }
        

        public Cliente(string n, string c, string r)
        {
            Nome = n;
            Cpf = c;
            Rg = r;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nome: " + Nome + "\tCpf: " + Cpf + "\tRg: " + Rg );
        }

        
    }
}