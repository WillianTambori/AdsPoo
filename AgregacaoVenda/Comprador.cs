using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
        public class Comprador
        {
            public float Verba { get; set; }

        
        public Comprador(float p)
        {
            Verba = p;
            
        }

        public void Compra()
        {
            System.Console.WriteLine("Verba: "+Verba);
        }
    }
}