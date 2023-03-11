using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public static int Contador { get; set; }

        static Conta()
        {
            Contador = 23;
        }
        public Conta() //construtor padrão
        {
            Contador = Contador + 1;
            //local da lógica
        }
        public Conta(int numero)
        {
            Numero = numero;
            Contador = Contador + 1;

        }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Contador = Contador + 1;

        }
        public void Mostrar()
        {
            System.Console.WriteLine("Numero: " + Numero + "\tTitular: " +Titular + "\tSaldo: " + Saldo);
        }
    }
}