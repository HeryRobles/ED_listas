using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblesCirculares
{
    public class Nodo
    {
        public int Valor { get; set; }   
        
        public Nodo EnlaceSiguiente { get; set; }
        public Nodo EnlaceAtras { get; set; }

        public Nodo(int valor, Nodo enlaceSiguiente = null, Nodo enlaceAtras = null)
        {
            Valor = valor;
            EnlaceSiguiente = enlaceSiguiente;
            EnlaceAtras = enlaceAtras;
        }
    }
}
