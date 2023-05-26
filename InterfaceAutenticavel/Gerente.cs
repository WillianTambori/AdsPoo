using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{// classe derivada: classe base, interface
    public class Gerente: Funcionario, IAutenticavel        
    {   
        public Gerente(string nome, int senha): base(nome,senha)
        {
            
        }
        public bool Autenticar(int senha)
        {
            return Senha == senha;

        }   
    }
}