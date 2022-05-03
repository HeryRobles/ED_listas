using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblesCirculares
{
    public class Lista
    {
        Nodo primero = new Nodo();
        Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        public bool ValidaVacio()
        {
            return (primero.EnlaceSiguiente == null && primero.EnlaceAtras == null);
        }

        public void Vaciar()
        {
            primero.EnlaceSiguiente = null;
            ultimo.EnlaceAtras = null;
        }

        public string RecorrerLista()
        {
            string datosLista = "";
            ultimo = primero;
            while (ultimo.EnlaceSiguiente != null)
            {
                ultimo = ultimo.EnlaceSiguiente;
                datosLista += $"{ultimo.Valor}\n";
            }
            return datosLista;
        }

        public void AgregarNodo(string dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if(primero == null)
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo;
                primero.EnlaceSiguiente = primero;
                primero.EnlaceAtras = ultimo;
            }
            else
            {
                ultimo.EnlaceSiguiente = nuevoNodo;
                nuevoNodo.EnlaceAtras = ultimo;
                nuevoNodo.EnlaceSiguiente = primero;
                ultimo = nuevoNodo;
                primero.EnlaceAtras = ultimo;
            }




        }
    }
}
