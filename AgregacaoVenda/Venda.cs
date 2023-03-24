using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador C { get; set; }
        public Vendedor V { get; set; }
        public Produto P { get; set; }

        
        public void concretizaVenda()
        {
            System.Console.WriteLine("VendaConcretizada");
        }
        public void cancelaVenda()
        {
            System.Console.WriteLine("VendaCancelada");

        }
    }
}