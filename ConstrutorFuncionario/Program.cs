using ConstrutorFuncionario;
Funcionario c1 = new Funcionario();
Funcionario c2 = new Funcionario("bob");
Funcionario c3 = new Funcionario("bob",2000);

c1.Mostrar();
c2.Mostrar();
c3.Mostrar();

Console.Write("Após o aumento: ");

c3.Aumento(10);

c3.Mostrar();

Console.Write("Quantidade de instâncias:" + Funcionario.Contador + "\n");