using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblesCirculares
{
    public class Nodo
    {
        public string Valor { get; set; }   
        
        public Nodo EnlacePrimero { get; set; }
        public Nodo EnlaceUltimo { get; set; }

        public Nodo(string valor = "", Nodo enlacePrimero = null)
        {
            Valor = valor;
            EnlacePrimero = enlacePrimero;
        }
    }
}
