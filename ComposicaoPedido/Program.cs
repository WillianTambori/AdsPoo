// função main()
using ComposicaoPedido;

Pedido p1 = new Pedido(1, "24/03/2023", 22, 1 , 54);

Console.WriteLine("Código do pedido: " + p1.CodigoPedido + "\tnº Pedidio Item: " + p1._PedidoItem.CodigoPedidoItem);

PedidoItem pItem = new PedidoItem(23,5,78);

Pedido p2 = new Pedido(2, "25/03/2023", pItem);

Console.WriteLine("Código do pedido: " + p2.CodigoPedido + "\tnº Pedidio Item: " + p2._PedidoItem.CodigoPedidoItem);

