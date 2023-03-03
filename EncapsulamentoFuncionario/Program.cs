using EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();
f1.Codigo =10; //set
f1.Nome= "bob";
f1.Salario = 1000;
System.Console.WriteLine("Código cadastrado: "+ f1.Codigo); //get Codigo
System.Console.WriteLine("Nome  cadastrado: "+ f1.Nome); //get Codigo
System.Console.WriteLine("Salário cadastrado: "+ f1.Salario); //get Codigo

Funcionario f2 = new Funcionario();

System.Console.WriteLine("\n<<<<<<<<<<<<<<<<cadastro>>>>>>>>>>>>>");
System.Console.WriteLine("insira o código do funcionário");
f2.Codigo = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("insira o nome do funcionario: ");
f2.Nome = Console.ReadLine();
System.Console.WriteLine("insira o salario dele:\n ");
f2.Salario = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Código cadastrado: "+ f2.Codigo); //get Codigo
System.Console.WriteLine("Nome  cadastrado: "+ f2.Nome); //get Codigo
System.Console.WriteLine("Salário cadastrado: "+ f2.Salario); //get 