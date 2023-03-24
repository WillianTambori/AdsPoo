using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        public double Saldo { get; set; }
        public string ChequeEspecial { get; set; }
    }

    public ContaCorrente(double s, string l)
    {
        Saldo = s;
        ChequeEspecial = l;
        
    }

    public void depositar{

    }
    public void sacar{

    }
    public void gerarExtrato{

    }
    ~ContaCorrente(){
        System.Console.WriteLine("conta corrente finalizada");
    }
}