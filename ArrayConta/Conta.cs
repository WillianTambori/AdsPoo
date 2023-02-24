using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta
{
    public class Conta
    {
        
        public int numero;
        public string titular = "";
        public double saldo;
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero + "\t\tTitular: " + titular +
            "\t\tSaldo: " + saldo);
        }

        public void Inserir()
        {
            System.Console.WriteLine("\n<<<<<<<<<<<<<<<<cadastro>>>>>>>>>>>>>");
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

        public bool Transferir(double valorTransferencia, Conta recebedor)
        {
            if(saldo >= valorTransferencia)
            {
                saldo -= valorTransferencia;
                recebedor.saldo += valorTransferencia;
                return true;
            }
            return false;
            
        }
    }
}