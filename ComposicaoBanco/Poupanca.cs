using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        

        public double Saldo { get; set; }

        public Poupanca(double s)
        {
            Saldo = s;
            
        }

        public void depositar{

        }
        public void sacar{

        }
        public void gerarRendimento{

        }
        ~Poupanca(){
            System.Console.WriteLine("finalizada a Poupança!");
        }
        
     

        
    }
}