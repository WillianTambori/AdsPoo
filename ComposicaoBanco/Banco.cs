using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        public List<Poupanca> Poups { get; set; }
        public List<ContaCorrente> Contas { get; set; }

        public Banco(Poupanca p, ContaCorrente c)
        {
            Poups = p;
            Contas = c;

            
        }


        ~Banco(){
            Poups = null;
            Contas = null;

        }
        
        
    }
}