// Método main()
using InterfaceAutenticavel;

//IAutenticavel it = new IAutenticavel(); error de compilação

Gerente g = new Gerente("Ana gerente",100);
Diretor d = new Diretor("Bia diretora",200);
Cliente c = new Cliente("Leo Cliente",300);

IAutenticavel it = g;
System.Console.WriteLine($"{g.Nome} -  {it.Autenticar(100)}");
it = d;
Console.WriteLine($"{d.Nome} - {it.Autenticar(210)} ");
IAutenticavel it2 = c;
Console.WriteLine($"{c.Nome} - {it2.Autenticar(300)} ");
