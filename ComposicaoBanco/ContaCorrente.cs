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
        
        public static int Contador { get; set; }
        static ContaCorrente(){

        }
        public ContaCorrente(double s, string l)
        {
            Saldo = s;
            ChequeEspecial = l;
            Contador ++;
            
        }

        public void Depositar(double s){

            Saldo += s;


        }
        public void Sacar(double s){
            if(s < Saldo)
                Saldo -= s;
            else
                System.Console.WriteLine("Saldo insuficiente");

        }
        public void gerarExtrato(){
            Console.WriteLine("\n>>>>>>>>>>>>>>>>Extrato<<<<<<<<<<<<<<<<<\n");
            System.Console.WriteLine("Seu Saldo é: " + Saldo);

        }
        ~ContaCorrente(){
            System.Console.WriteLine("conta corrente finalizada");
        }
    }
}