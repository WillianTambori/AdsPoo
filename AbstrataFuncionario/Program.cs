using AbstrataFuncionario;

// Funcionario f = new Funcionario(); não é permitida a instância

Assalariado a1 = new Assalariado(1,"Leo",1000);
Assalariado a2 = new Assalariado(2,"tao",1500);
Comissionado c1 = new Comissionado(3,"joao",1300);
Comissionado c2 = new Comissionado(4,"Ana",1600);

Departamento d1 = new Departamento(50,"TI");
Departamento d2 = new Departamento(51,"RH");

d1.Admitir(a1);
d1.Admitir(a2);
d1.Admitir(c1);
d1.Admitir(c2);

d1.Listar();
//d1.Excluir(1);
//d1.Listar();
//d1.Excluir(1);

//double folha = d1.CalcularFolha(30);
//Console.WriteLine($"Folha de pagamento do departamento {d1.Descricao} {d1.CalcularFolha(30):C}\n");

Dependente dep1 = new Dependente(1,"bia",14);
Dependente dep2 = new Dependente(2,"tia",20);
Dependente dep3 = new Dependente(3,"fia",24);
Dependente dep4 = new Dependente(4,"bah",18);
Dependente dep5 = new Dependente(5,"bê",13);
Dependente dep6 = new Dependente(6,"tao",8);

a1.addDependente(dep1);
a1.addDependente(dep2);
a1.addDependente(dep3);
a2.addDependente(dep4);
c1.addDependente(dep5);
c1.addDependente(dep6);
a1.remDepMaior();
c2.addDependente(dep3);

a2.ListarDependente();
a1.ListarDependente();
c2.ListarDependente();
c1.ListarDependente();

a1.remDepMaior();
a2.remDepMaior();
c2.addDependente(dep6);
c1.remDepCod(5);

c2.ListarDependente();
c1.ListarDependente();
a2.ListarDependente();
a1.ListarDependente();

d1.MostrarQtdDependentesPorFuncionarios();









