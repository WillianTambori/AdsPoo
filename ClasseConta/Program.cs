using ClasseConta;
Conta c1; //declaração da variável c1;
c1 = new Conta(); //instanciação do objeto c1
c1.MostrarAtributos();
c1.Depositar(500);
c1.MostrarAtributos();

Conta c2 = new Conta();

c1.Inserir();
c2.Inserir();

c2.Sacar(10);
c2.MostrarAtributos();
c2.Depositar(200);
c2.MostrarAtributos();
c1.Transferir(100,c2);

c1.MostrarAtributos();
c2.MostrarAtributos();


