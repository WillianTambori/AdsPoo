using AgregacaoContaVetor;

var cli1 = new Cliente("lia","123-90","1111");
Cliente cli2 = new Cliente("léo", "123-67-0","2222");

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 1000;
c1.Titular = new List<Cliente>();
c1.Titular.Add(cli1);
c1.Titular.Add(cli2);

foreach(Cliente cli in c1.Titular)
    cli.Mostrar();
    Console.WriteLine("Quantidade de correntistas: " + c1.Titular.Count);
