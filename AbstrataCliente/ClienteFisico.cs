using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteFisico: Cliente
    {
        public int Cpf { get; set; }
        public int Rg { get; set; }

        public ClienteFisico(int codigo, string nome, int cpf,int rg):base(codigo,nome)
        {
            Cpf = cpf;
            Rg = rg;
            
        }
        public override void Mostrar(){
            Console.WriteLine($"Código : {Codigo,5} \tNome: {Nome,15} \tCpf: {Cpf,5} \tRg: {Rg,5} ");
        }
        
    }
}