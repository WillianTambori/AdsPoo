using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int code;
        public string description;
        public double price;
        public void Inserir()
        {
            System.Console.WriteLine("insira o código do produto");
            code = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("insira a descrição dele: ");
            description = Console.ReadLine();
            System.Console.WriteLine("insira o preço dele: ");
            price = Convert.ToDouble(Console.ReadLine());
        }
        public void Mostrar()
        {
            System.Console.WriteLine("código: " + code + "\ndescrição: " + description + "\npreço: " + price);

        }
        public void Somar(double a, double b, double c)
        {
            double total;
            total = a + b + c;

            System.Console.WriteLine("\n\nTotal\n: " +total);

        }
        
    }
}