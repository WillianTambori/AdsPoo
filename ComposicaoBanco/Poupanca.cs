using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        
        
        public double Saldo { get; set; }
        public static int Contador { get; set; }

        static Poupanca(){

        }
        public Poupanca(double s)
        {
            Saldo = s;
            Contador ++;
            
        }

        public void depositar(double s){
            
            Saldo += s;
        
        }
        public void sacar(double s){

            if(s < Saldo)
                Saldo -= s;
            else
                System.Console.WriteLine("Saldo insuficiente");

        }
        public void gerarRendimento(){

            Console.WriteLine("\n>>>>>>>>>>>>>>>>Extrato<<<<<<<<<<<<<<<<<\n");
            System.Console.WriteLine("Seu Saldo é: " + Saldo);


        }
        ~Poupanca(){
            System.Console.WriteLine("finalizada a Poupança!");
        }
        
     

        
    }
}