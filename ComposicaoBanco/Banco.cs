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

        public Banco(List<Poupanca> p)
        {
            Poups = p;
            
        }

        public Banco(List<ContaCorrente> c)
        {
            Contas = c;
            
        }
        public void AbrirConta(){

        }
        public void AbrirPoupança(){

        }


        ~Banco(){
            Poups = null;
            Contas = null;

        }
        
        
        
    }
}