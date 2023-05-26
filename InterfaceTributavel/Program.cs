using InterfaceTributavel;

Itributavel tc = new ContaCorrente(1,5000);
Itributavel ts = new SeguroDeVida();

TotalizadorDeTributos tributos = new TotalizadorDeTributos();


tributos.Adicionar(tc);

tributos.Adicionar(ts);

Console.WriteLine($"total de tributos a ser pago {tributos.total:c}");
