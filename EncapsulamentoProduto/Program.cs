// funçÕ Min() implícita
using System;
using EncapsulamentoProduto;

Produto p1 = new Produto();
System.Console.WriteLine("\n<<<<<<<<<<<<<<<<cadastro>>>>>>>>>>>>>");
System.Console.WriteLine("insira o código do produto");
p1.Code = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("insira a descrição dele: ");
p1.Description = Console.ReadLine();
System.Console.WriteLine("insira o preço dele: ");
p1.Price = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("\n");

Produto p2 = new Produto();
System.Console.WriteLine("\n<<<<<<<<<<<<<<<<cadastro>>>>>>>>>>>>>");
System.Console.WriteLine("insira o código do produto");
p2.Code = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("insira a descrição dele: ");
p2.Description = Console.ReadLine();
System.Console.WriteLine("insira o preço dele: ");
p2.Price = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("\n");