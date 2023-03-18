using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public float Comissao { get; set; }

    
        public Vendedor(float C)
        {
            Comissao = C;
            
        }
        public void Vende()
        {
            System.Console.WriteLine("comissao: "+ Comissao);

        }
    }
}