using System.Collections.Generic;
using estudo_p1;
// usando tenario



int a=3,b=2, valor;
valor =(a>b)? a:b;
// usando vetor
int[] vet= new int[5];
for(int i = 0; i<5;i++)
    vet[i]= i*5;


Console.WriteLine("Hello, World!" + valor);
int c = 0;
while(c < 5){
    Console.WriteLine(vet[c]);
    c++;
}
//usando vetor com objetos
/*
Casa[] vetcasa = new Casa[3];
for(int i =0;i <vetcasa.Length; i++){
    vetcasa[i]= new Casa();
    Console.WriteLine("informe a cor");
    vetcasa[i].Cor = Console.ReadLine();
    Console.WriteLine("informe o comodo");
    vetcasa[i].Comodo = Console.ReadLine();

}
*/

Casa c1 = new Casa("azul", "três");
Casa c2 = new Casa("verde", "cinco");
Casa c3 = new Casa("amarelo", "seis");
List<Casa> vetcasa = new List<Casa>();
vetcasa.Add(c1);
vetcasa.Add(c2);
vetcasa.Add(c3);
    

foreach(Casa d in vetcasa)
    Console.WriteLine("casa da Cor "+d.Cor+" e de "+d.Comodo+" Comodos");

/*
double valor = 15000000000;
DateTime w = System.DateTime.Now;
Console.WriteLine(String.Format(" {1:HH:MM}   " , valor,w));
*/
Console.WriteLine($" total de estâncias {Casa.num}");


