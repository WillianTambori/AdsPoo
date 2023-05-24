using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Assalariado: Funcionario
    {
        public Assalariado(int codigo, string nome, double salario):base(codigo,nome,salario)
        {
            
        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario *30/ diasUteis;
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