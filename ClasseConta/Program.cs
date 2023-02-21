using ClasseConta;
Conta c1; //declaração da variável c1;
c1 = new Conta(); //instanciação do objeto c1
c1.MostrarAtributos();
c1.Depositar(500);
c1.MostrarAtributos();

Conta c2 = new Conta();
Console.Write("Digite o número da conta: ");
c2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular da conta: ");
c2.titular = Console.ReadLine();
Console.Write("Digite o saldo da conta: ");
c2.saldo = Convert.ToDouble(Console.ReadLine());
c2.MostrarAtributos();
c2.Sacar(10);
c2.MostrarAtributos();
c2.Depositar(200);
c2.MostrarAtributos();
