using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoPedido
{
    public class PedidoItem
    {
        public int CodigoPedidoItem { get; set; }
        
        public int Qtde { get; set; }
        public int CodigoProduto { get; set; }

        public PedidoItem(int cp, int q, int cprod)
        {
            CodigoPedidoItem = cp;
            Qtde = q;
            CodigoProduto = cprod;           
        }
    }
}