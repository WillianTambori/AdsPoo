using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        public int code;
public string nome = "";
public double salario;

public void Mostrar()
{
System.Console.WriteLine("code: "+code+"\nnome: " + nome +" \nsalario:" + salario);
}
public void Inserir()
{
System.Console.WriteLine("insira o código do funcionário");
code = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("insira o nome do funcionario: ");
nome = Console.ReadLine();
System.Console.WriteLine("insira o salario dele: ");
salario = Convert.ToDouble(Console.ReadLine());

}
    }
}