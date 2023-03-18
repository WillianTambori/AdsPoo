using System;
using AgregacaoConta;
// função Main() implicita

Cliente objcli = new Cliente();
objcli.Nome = "Bia";
objcli.Cpf = "123.123.123-00";
objcli.Rg = "12.123.123-3";
objcli.Endereco = new Endereco();
objcli.Endereco.Logradouro = "AV. castro";
objcli.Endereco.Numero = 23;
objcli.Endereco.Cidade = "Indiana";
objcli.Endereco.Bairro = "Centro";


Conta c1 = new Conta();
c1.Numero = 1;
c1.Titular = objcli;
c1.Saldo = 100;

Endereco Objendereco = new Endereco();
Objendereco.Logradouro = "Rua joão munhoz";
Objendereco.Numero = 23;
Objendereco.Cidade = "Amelia ";
Objendereco.Bairro = "Centrinho ";


Conta c2 = new Conta();
c2.Numero = 2;
c2.Titular = new Cliente();
c2.Titular.Nome = "Bob";
c2.Titular.Cpf = "321.321.321-00";
c2.Titular.Rg = "12.321.321-9";
c2.Titular.Endereco = Objendereco;



c1.Mostrar();
c2.Mostrar();

