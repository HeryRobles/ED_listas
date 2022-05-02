using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplesCirculares
{
    public class Lista
    {
        //Declaramos los apuntadores iniciales de tipo Nodo:
        Nodo nodoInicial;
        Nodo nodoActual;
        Nodo nodoUltimo;

        //Creamos el constructor:
        public Lista()
        {
            this.nodoActual = new Nodo();
            this.nodoInicial = new Nodo();
            this.nodoUltimo = new Nodo();   
        }

        //Métodos:
        public bool ValidaVacio()
        {
            return (nodoInicial.EnlaceSiguiente == null);
            return (nodoUltimo == null);
        }

        public void Vaciar ()
        {
            nodoInicial.EnlaceSiguiente = null;
            nodoUltimo.EnlaceSiguiente = null;
        }

        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.EnlaceSiguiente != null)
            {
                nodoActual = nodoActual.EnlaceSiguiente;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }


        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.EnlaceSiguiente != null)
            {
                nodoActual = nodoActual.EnlaceSiguiente;
            }

            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.EnlaceSiguiente = nodoNuevo;
            nodoNuevo.EnlaceSiguiente = nodoInicial;
            nodoUltimo = nodoActual;
        }

        //public Nodo Buscar(string dato)
        //{
        //    if (ValidaVacio() == false)
        //    {
        //        Nodo nodoBusqueda = nodoInicial;
        //        while (nodoBusqueda != null)
        //        {
        //            nodoBusqueda = nodoBusqueda.EnlaceSiguiente;
        //            if (nodoBusqueda.Valor == dato)
        //            {
        //                return nodoBusqueda;
        //            }
        //        }
        //    }
        //    return null;
        //}
        //public void BorrarNodo(string dato)
        //{
        //    if (ValidaVacio() == false)
        //    {
        //        nodoActual = Buscar(dato);
        //        if (nodoActual != null)
        //        {
        //            Nodo nodoAnterior = BuscarAnterior(dato);
        //            nodoAnterior.EnlaceSiguiente = nodoActual.EnlaceSiguiente;
        //            nodoActual.EnlaceSiguiente = nodoAnterior;
        //        }
        //    }
        //}





    }
}
