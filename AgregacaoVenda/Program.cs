using AgregacaoVenda;

Comprador c1 = new Comprador(3000);
Vendedor v1 = new Vendedor(100);
Produto p1 = new Produto(30,400);
Venda venda = new Venda();



System.Console.WriteLine("produto: ");
venda.P = p1;
venda.P.vendido();
System.Console.WriteLine("Comissão do vendedor: ");
venda.V = v1;
venda.V.Vende();
System.Console.WriteLine("verba para comprar: ");
venda.C = c1;
venda.C.Compra();


