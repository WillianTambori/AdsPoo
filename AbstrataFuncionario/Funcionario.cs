using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> VtDep { get; set; }     

        
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            VtDep = new List<Dependente>();
            
        }
        public virtual void addDependente(Dependente d)
        {
            VtDep.Add(d);
        }
        public virtual void remDepMaior(){
            bool verdadeiro=false;
            for(int i=0; i<VtDep.Count;i++){
                Dependente d = VtDep.ElementAt<Dependente>(i);
                if (d.verificarMaiorIdade()){
                    VtDep.RemoveAt(i);
                    verdadeiro = true;
                }
            }
            Console.WriteLine(verdadeiro?"\nDependentes maiores de 18 anos Removidos":"\nNão há dependentes maiores de 18 anos");

        }
        public virtual void remDepCod(int codigo){
            bool verdadeiro=false;
            for(int i=0; i<VtDep.Count;i++){
                Dependente d = VtDep.ElementAt<Dependente>(i);
                if (d.Codigo == codigo){
                    VtDep.RemoveAt(i);
                    verdadeiro = true;
                }
            }
            Console.WriteLine(verdadeiro?"\nDependente do codigo: "+codigo+" Removido":"\nNão há dependentes com esse código");

        }
        public virtual void ListarDependente(){
            Console.WriteLine("\nLista de Dependendentes do " + Nome);
            for(int i=0;i< VtDep.Count;i++){
                Dependente d = VtDep.ElementAt<Dependente>(i);
                Console.WriteLine($"dependente {i+1}-Código: {d.Codigo,3} nome: {d.Nome,10} idade: {d.Idade,2}");

            }
        }
        public virtual int QtdDependente(){
            int qtd = VtDep.Count;
            return qtd;

        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void Mostrar(){
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalario: {Salario}");
        }
        

        
    }
}