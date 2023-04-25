using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_p1
{
    public class Casa
    {
        private string cor;
        private string comodo;

        public static int num = 0;

        public string Cor { get => cor; set => cor =value; }
        public string Comodo { get => comodo; set => comodo = value; }

        public Casa(){
            num++;
        }
        public Casa(string cor, string comodo){
            this.cor = cor;
            this.comodo = comodo;
            num++;

        }



    }
}