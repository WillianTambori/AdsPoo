using EncapsulamentoConta;

Conta c = new Conta();
c.Numero = 1;
c.Titular = "Paulo";
c.Saldo = 100;
c.Porcentagem = 3.5;
// Exemplo de utilização do get para um cáclculo
double reajuste = c.Saldo * c.Porcentagem / 100;
System.Console.WriteLine(reajuste);
