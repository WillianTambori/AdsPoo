using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador c { get; set; }
        public Vendedor v { get; set; }
        public Produto p { get; set; }

        public Venda(Comprador C ,Vendedor V ,Produto P)
        {
            c = C;
            v = V;
            p = P;

            
        }
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