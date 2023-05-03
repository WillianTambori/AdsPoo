using System.Reflection.PortableExecutable;
using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 123;

ClienteFisico cf = new ClienteFisico();
cf.Codigo =2;
cf.Nome= "lia";
cf.Endereco="av.fatec,344";
cf.Rg=22;
cf.Cpf=22;
cf.Mostrar();
ClienteJuridico cj = new ClienteJuridico();
cj.Codigo =2;
cj.Nome= "empresa/Sa";
cj.Endereco="av.paulo souza,344";
cj.Ie=33;
cj.Cnpj=33;
cj.Mostrar();

Cliente c2 = new Cliente(11,"Onze","R.onze,11");
c2.Mostrar();
ClienteFisico cf2 = new ClienteFisico(22,"Vinte","Vinte e dois,22",2222,22);
cf2.Mostrar();
ClienteJuridico cj2 = new ClienteJuridico(33,"Trinta","r.trinta e trẽs,33",3333,33);
cj2.Mostrar();

