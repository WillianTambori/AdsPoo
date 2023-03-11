using ConstrutorConta;
Conta c1 = new Conta();
c1.Mostrar();
Conta c2 = new Conta(1);
c2.Mostrar();

Conta c3 =  new Conta(13,"bob", 100);
c3.Mostrar();
System.Console.WriteLine("Qtde de instÂncias :" + Conta.Contador);
//Quantas instâncias foram realizadas?
//ClasseEstatica c = new ClasseEstatica?();
ClasseEstatica.MostrarFrase();
