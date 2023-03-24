using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string Data { get; set; }
        public List<ItemNf> VetItemNf { get; set; }

        public NotaFiscal(int nf, string dt, List<ItemNf> vetItens)
        {
            NumeroNf = nf;
            Data = dt;
            VetItemNf = vetItens;
            
            
        }
        ~NotaFiscal()
        {
            VetItemNf = null;
            Console.WriteLine("Destruindo o objeto da Nota Fiscal");
        }
    }
}