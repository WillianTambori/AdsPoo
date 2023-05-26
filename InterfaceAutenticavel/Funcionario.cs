using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Senha { get; set; }
        public Funcionario(string nome,int senha)
        {
            Nome = nome;
            Senha = senha;
        }
    }
}