using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class SeguroDeVida: Itributavel
    {
        public double CalcularTributos()
        {
            return 75;
        }
    }
}