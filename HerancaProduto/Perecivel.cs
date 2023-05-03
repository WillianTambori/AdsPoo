using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        private string dtValidade;
        public string DtValidade
        {
            get { return dtValidade; }
            set { dtValidade = value; }
        }
        private string dtfabrica;
        public string DtFabricacao
        {
            get { return dtfabrica; }
            set { dtfabrica = value; }
        }
        public Perecivel(int c, string n, double p,string v, string f)
        :base(c,n,p)
        {
            DtValidade = v;
            DtFabricacao = f;
            
        }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Data de Validade:{DtValidade,10} \tData de fabricação: {DtFabricacao}");
        }

        
    }
}