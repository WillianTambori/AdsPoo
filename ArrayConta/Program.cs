using System;
//funç~so Main() implícita
using ArrayConta;
Conta[] vetConta = new Conta[3];
double somaSaldo = 0;
//cadastrar contas dentro de cada índice do vetor
for(int i = 0;i< vetConta.Length; i++)
{
    //instâncciação de CADA posição
    vetConta[i] =new Conta();
    System.Console.Write("Digite o número: ");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Digite o títular: ");
    vetConta[i].titular = Console.ReadLine();
    System.Console.Write("Digite o saldo: ");
    vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
    somaSaldo += vetConta[i].saldo;

}
somaSaldo = 0;
System.Console.WriteLine(($"valor total dos saldos {somaSaldo:C}"));
foreach(Conta c in vetConta)
{
    c.MostrarAtributos();
    somaSaldo += c.saldo;
    }
System.Console.WriteLine(($"valor total dos saldos {somaSaldo:N}"));

