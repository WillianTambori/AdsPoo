using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoPedido
{
    public class Pedido
    {
        public int CodigoPedido { get; set; }
        public string DataPedido { get; set; }
        public PedidoItem _PedidoItem { get; set; }//relacionamento com a classe PedidoItem
        public Pedido(int cp, string dt, int cpi, int q, int cprod)    
        {
            CodigoPedido = cp;
            DataPedido = dt;
            _PedidoItem = new PedidoItem(cpi,q,cprod);//composição
        }
        public Pedido(int cp, string dt, PedidoItem pi)
        {
            CodigoPedido = cp;
            DataPedido = dt;
            _PedidoItem = pi; //COMPOSIÇÃO
            
        }
    
    }
}