
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadrõesProjetos
{
    public class Singleton
    {
        public static int quantidade;
        
        private Singleton(){
            quantidade++;
        }

        private static Singleton instancia;
        public static Singleton Instancia
        {
            get { 
                if(instancia == null){
                    instancia = new Singleton();
                    Console.WriteLine("instancia nº:"+quantidade);
                }
                return instancia; 
                }
            set { instancia = value; }
        }
        
    }
}