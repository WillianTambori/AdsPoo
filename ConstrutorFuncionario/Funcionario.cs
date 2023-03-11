using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }    
        public double Salario { get; set; }
        public static int Contador { get; set; }
        public static int CodigoInicial { get; set; }

        static Funcionario()
        {
            CodigoInicial = 100;
        }
        
        public Funcionario()
        {
            Contador ++;
            Codigo = CodigoInicial + Contador;
        }
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
            Contador ++;
            Codigo = CodigoInicial + Contador;
        }
        public Funcionario(string nome)
        {
            
            Nome = nome;
            Contador  ++;
            Codigo = CodigoInicial + Contador;
        }

        public void Mostrar()
        {
            Console.WriteLine("\n>>>>>>>>>>>>>>>>Funcionario<<<<<<<<<<<<<<<<<\n");
            Console.WriteLine("code: "+ Codigo +"\nnome: " + Nome +" \nsalario:" + Salario);
        }
        
        public void Aumento( double aumento)
        {
            Salario += Salario * aumento/100;
        }
    }

}