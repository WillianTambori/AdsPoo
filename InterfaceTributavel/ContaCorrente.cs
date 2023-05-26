using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class ContaCorrente: Itributavel
    {
        public int Codigo { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente(int codigo, double saldo)
        {
            Codigo = codigo;
            Saldo = saldo;
        }
        public double CalcularTributos(){
            return Saldo * 0.05;
        }

    }
}