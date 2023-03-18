using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string Nome { get; set; }    
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public Endereco Endereco { get; set; }    

        public void Mostrar()
        {
            Console.WriteLine("Nome: " + Nome + "\tCpf: " + Cpf + "\tRg: " + Rg );
            Endereco.Mostrar();

        }


    }
}