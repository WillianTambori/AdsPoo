using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Comissionado:Funcionario
    {
        public double Porcentagem { get; set; } 

    
        public Comissionado(int codigo, string nome, double salario):base(codigo,nome,salario)
            {
                Porcentagem = 0.20;
            }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario = Salario * 30 / diasUteis * Porcentagem + Salario;
        }
        public override void Mostrar(){
            base.Mostrar();//chamado o método da superclasse mostrando códig, nome e salário
            Console.WriteLine($"porcenteagem: {Porcentagem,5}");
        }
        public override void addDependente(Dependente d){
            base.addDependente(d);
        }
        public override void remDepCod(int cod){
            base.remDepCod(cod);
        }
        public override void remDepMaior(){
            base.remDepMaior();
        }
        public override void ListarDependente(){
            base.ListarDependente();
        }
        public override int QtdDependente()
        {
            return base.QtdDependente();
        }


    }
}