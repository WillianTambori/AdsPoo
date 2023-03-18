using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }

        public void Mostrar(){
            Console.Write("Logradouro: " + Logradouro + "\tNumero: " + Numero + "\tCidade: " + Cidade + "\t Bairro: " + Bairro);
        }

        
    }
}