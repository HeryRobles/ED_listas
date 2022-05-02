using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplesCirculares
{
    public class Nodo
    {
        public string Valor { get; set; }

        public Nodo EnlaceSiguiente { get; set; }

        public Nodo(string valor = "", Nodo nodoSig = null)
        {
            Valor = valor;
            EnlaceSiguiente = nodoSig;
        }

    }
}
