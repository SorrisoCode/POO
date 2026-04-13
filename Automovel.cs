using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Automovel
    {
        //visibilidade private, public, protected, internal
        //public - pode ser acessado por qualquer classe
        //private - só pode ser acessada pela própria classe
        //protected - própria classe e derivadas
        //internal - só pelo mesmo assembly

        //construtor
        //métodos de acesso
        /*public void SetMarca(string x) 
        { 
            Marca = x;
        }
        public string GetMarca() 
        {  
            return Marca; 
        } */
        public string Marca { get; set; }  //get retorna - set atribui
        public Automovel() 
        { 
            
        }
    }
}
