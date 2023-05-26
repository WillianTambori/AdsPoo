using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Cliente: IAutenticavel
    {
        public string Nome { get; set; }
        public int Senha { get; set; }

        public Cliente(string nome,int senha)   
        {
            Nome = nome;
            Senha = senha;
        }
        public bool Autenticar(int senha)
        {
            return Senha == senha;
        }
    }
}