using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        private double porcentagem;
        public double Porcentagem
        {
            get { return porcentagem; }
            set { porcentagem = value; }
        }
        
        
    }
}