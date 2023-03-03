using System;
using ArrayProduto;
Produto[] vetProduto = new Produto[2];
double somaMais = 0;

for(int i = 0;i< vetProduto.Length; i++){
    vetProduto[i] =new Produto();
    System.Console.Write("Digite o número: ");
    vetProduto[i].code = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Digite o títular: ");
    vetProduto[i].description = Console.ReadLine();
    System.Console.Write("Digite o saldo: ");
    vetProduto[i].price = Convert.ToDouble(Console.ReadLine());
    vetProduto[i].Mostrar();
    if (vetProduto[i].price > 100)
        somaMais += vetProduto[i].price;
    
}

double media = 0;
media = somaMais/2;
System.Console.WriteLine("media: " + media);




