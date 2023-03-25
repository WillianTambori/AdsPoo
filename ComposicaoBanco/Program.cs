using ComposicaoBanco;
ContaCorrente cc1 = new ContaCorrente(1000.00,"150");
Poupanca cp1 = new Poupanca(3000);
ContaCorrente cc2 = new ContaCorrente(4000.00,"150");
Poupanca cp2 = new Poupanca(5000);
cp1.sacar(200);
cp1.sacar(3200);

List<ContaCorrente> Vetcc = new List<ContaCorrente>(); 
List<Poupanca> Vetcp = new List<Poupanca>();
Vetcc.Add(cc1);
Vetcp.Add(cp1);
Vetcc.Add(cc2);
Vetcp.Add(cp2);
Banco c1 = new Banco(Vetcp);
Banco c2 = new Banco(Vetcc);

foreach (Poupanca it in c1.Poups)
    Console.WriteLine("conta Poupança: " + it.Saldo);

foreach (ContaCorrente it in c2.Contas)
    Console.WriteLine("Conta Corrente: " + it.Saldo + "\t Limite da conta corrente: " + it.ChequeEspecial);
Console.WriteLine("Numero de contas correntes: " + ContaCorrente.Contador);
Console.WriteLine("Numero de contas Poupanças: " + Poupanca.Contador);

c1= null;
c2 = null;
GC.Collect();


