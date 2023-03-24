using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNf
    {
        public int Qtde { get; set; }
        public ItemNf(int q)
        {
            Qtde = q;
            
        }
        ~ItemNf() //Destrutor
        {
            Console.WriteLine("Destruindo o Item Nota Fiscal");
        }   
    }
}