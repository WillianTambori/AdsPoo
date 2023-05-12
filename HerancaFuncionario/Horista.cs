using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Horista:Funcionario
    {
        private double qtdeHorasSemana;
        public double QtdeHorasSemana

        {
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }
        public Horista(int  codigo, string nome, double salario, double qtdeHorasSemana):base(codigo,nome,salario)
        {
            QtdeHorasSemana = qtdeHorasSemana;
            
        }
        public void Mostrar(){
            base.Mostrar();
            Console.WriteLine($"\t Quantidade de horas trabalhadas{QtdeHorasSemana,5}");
        }

    }
}