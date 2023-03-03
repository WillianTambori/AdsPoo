using System.Runtime.CompilerServices;
using System.Globalization;
using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;
        public int Codigo //métodos de encaśulamento/propriedades
        {
            set
            {
                this.codigo = value;

            }
            get 
            {
                return this.codigo;    
            }
        }
        public string Nome
        {
            get 
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
        public double Salario
        {
            set
            {
                this.salario = value;

            }
            get 
            {
                return this.salario;
            }
        }
    
    }
}