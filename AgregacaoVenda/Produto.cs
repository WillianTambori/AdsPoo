using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public float Preco { get; set; }
        public int Tamanho { get; set; }

        public void vendido(){
            Console.WriteLine("preço: " + Preco +  "\tTamanho: " + Tamanho);
        }

        public Produto(float p, int t)
        {
            Preco = p;
            Tamanho = t;
        }
    }
}