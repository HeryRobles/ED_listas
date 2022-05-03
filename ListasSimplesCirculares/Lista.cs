﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplesCirculares
{
    public class Lista
    {
        //Declaramos los apuntadores iniciales de tipo Nodo:
        Nodo nodoInicial; //El primer nodo.
        Nodo nodoActual;//El ultimo nodo.
       
        //Creamos el constructor:
        public Lista()
        {
            nodoInicial = new Nodo();
            nodoInicial.Enlace= nodoInicial;    
                     
        }

        //Métodos:
        public bool ValidaVacio()
        {
            return (nodoInicial.Enlace == nodoInicial);
            
        }

        public void Vaciar ()
        {
            nodoInicial.Enlace = nodoInicial;
            
        }

        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.Enlace != nodoInicial)
            {
                nodoActual = nodoActual.Enlace;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }

        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Enlace != nodoInicial)
            {
                nodoActual = nodoActual.Enlace;
            }

            Nodo nodoNuevo = new Nodo(dato, nodoInicial);
            nodoActual.Enlace = nodoNuevo;
            
         
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
