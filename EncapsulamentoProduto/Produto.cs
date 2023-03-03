using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        private int code;
        public int Code
        {
            get { return code; }
            set
             { 
               if(value > 0)
                code = value;
                else
                System.Console.WriteLine("código inválido! ");
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set 
            {
                if (value != "")
                 description = value;
                 else
                 System.Console.WriteLine(" o nome deve ter conteúdo! "); 
                 
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set 
            {
                if(value > 0)
                    price = value;
            else
                System.Console.WriteLine("Preço inválido! ");
            }
        }
        

    }
}