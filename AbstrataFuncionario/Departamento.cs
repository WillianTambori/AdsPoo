using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string desc)
        {
            Codigo = codigo;
            Descricao = desc;
            VetF = new List<Funcionario>();
            
        }
        public void Admitir(Funcionario f)
        {
            
            VetF.Add(f);
        }
        public void Listar(){
            Console.WriteLine("\nLista de funcionário do departamento"+ Descricao);
            for(int i =0; i< VetF.Count;i++){
                Funcionario f = VetF.ElementAt<Funcionario>(i);//generalização
                f.Mostrar();
            }
            Console.WriteLine(".......................................\n");
        }
        public void ExcluirFrase(int codigo_exclusao){
            string resposta = "Funcionario não encontrado";
            for(int i = 0;i < VetF.Count; i++){
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if(f.Codigo == codigo_exclusao){

                VetF.Remove(f);
                resposta = "Funcionário excluído";
                }
                
            }
            Console.WriteLine(resposta);
        }
        public void Excluir(int codigo_exclusao){
            bool resposta = false;
            for(int i = 0;i < VetF.Count; i++){
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if(f.Codigo == codigo_exclusao){

                VetF.Remove(f);
                resposta = true;
                }
                
            }
            Console.WriteLine(resposta?"Funcionário excluído com sucesso.":"Funcionário não encontrado");
        }
        public double CalcularFolha(int diasUteis){
            double folha = 0;
            for (int i = 0; i < VetF.Count;i++) 
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }
        public void MostrarQtdDependentesPorFuncionarios(){
            for(int i=0;i<VetF.Count;i++){
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                int qtd = f.QtdDependente();
                Console.WriteLine("\nQuantidade de dependentes do  " + f.Nome +" é " + qtd);
            }
        }

    }

}