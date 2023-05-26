using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class TotalizadorDeTributos
    {
        public double total {get;private set;}

        public void Adicionar(Itributavel t){
            this.total += t.CalcularTributos();
        }
    }
}