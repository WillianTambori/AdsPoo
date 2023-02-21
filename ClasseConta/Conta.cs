using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        public int numero;
        public string titular = "";
        public double saldo;
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero + "\nTitular: " + titular +
            "\nSaldo: " + saldo);
        }
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
    }
}