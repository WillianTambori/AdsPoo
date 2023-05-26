using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Diretor :Funcionario, IAutenticavel
    {
        
        public Diretor(string nome, int senha): base(nome,senha)
        {
            
        }
        public bool Autenticar(int senha)
        {
            return Senha == senha;

        }  
    }
}