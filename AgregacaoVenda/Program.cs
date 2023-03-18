using AgregacaoVenda;

Comprador c1 = new Comprador(3000);
Vendedor v1 = new Vendedor(100);
Produto p1 = new Produto(30,400);
Venda venda = new Venda(c1,v1,p1);

System.Console.WriteLine("produto: ");
venda.p.vendido();
System.Console.WriteLine("Comissão do vendedor: ");
venda.v.Vende();
System.Console.WriteLine("verba para comprar: ");
venda.c.Compra();


