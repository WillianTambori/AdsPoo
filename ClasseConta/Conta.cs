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

        public void Inserir()
        {
            Console.Write("Digite o número da conta: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            titular = Console.ReadLine();
            Console.Write("Digite o saldo da conta: ");
            saldo = Convert.ToDouble(Console.ReadLine());
        }
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void Transferir( Conta Receber)
        {
            double total;
            System.Console.WriteLine("Informe o valor da transferência: ");
            total = Convert.ToDouble(Console.ReadLine());
            saldo -= total;
            Receber.saldo += total; 
            


        }
    }
}