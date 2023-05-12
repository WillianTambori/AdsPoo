using AbstrataFuncionario;

// Funcionario f = new Funcionario(); não é permitida a instância

Assalariado a1 = new Assalariado(1,"Leo",1000);
Assalariado a2 = new Assalariado(2,"tao",1500);
Comissionado c1 = new Comissionado(3,"joao",1300);
Comissionado c2 = new Comissionado(4,"Ana",1600);

a1.Mostrar();
a1.CalcularSalario(30);
c1.Mostrar();
c1.CalcularSalario(30);
c1.Mostrar();