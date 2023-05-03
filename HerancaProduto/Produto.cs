using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Produto
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public Produto(int c, string n, double p)
        {
            Codigo = c;
            Nome = n;
            Preco = p;

        }
        public void Mostrar(){
            Console.WriteLine($"Codigo: {Codigo} Nome: {Nome,10} Preco: {Preco}");
                
        }
        
        
    }
}