using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente //classe Base. superclasse, classe pai/mãe 
    {
        protected int codigo;// atributos ou membros genéricos
        protected string nome;// protected é colocado na classe base
        protected string endereco;

        public void Mostrar(){
            Console.WriteLine($"Código: {codigo,5} Nome: {nome,10} endereco: {endereco,20}");
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
       
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public Cliente()
        {
            
        }
        public Cliente(int codigo, string nome, string endereco)
        {
            Codigo=codigo;
            Nome =nome;
            Endereco= endereco;
            
        }  
        
        
    }
}