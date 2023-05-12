/*
using PadrõesProjetos;

Singleton c1 = Singleton.Instancia;
Singleton c2 = Singleton.Instancia;
*/
using PadrõesProjetos;
var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListParts());



