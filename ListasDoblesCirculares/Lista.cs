﻿using System;
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
            if (primero == null)
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

        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = primero;
                while (nodoBusqueda != null)
                {
                    nodoBusqueda = nodoBusqueda.EnlaceSiguiente;
                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = primero;
                while (nodoBusqueda.EnlaceSiguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.EnlaceSiguiente;
                    Indice++;
                    if (Indice == indice)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;

        }

        Nodo BuscarAnterior(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = primero;
                while (nodoBusqueda.EnlaceSiguiente != null && nodoBusqueda.EnlaceSiguiente.Valor != dato)
                {
                    nodoBusqueda = nodoBusqueda.EnlaceSiguiente;
                    if (nodoBusqueda.EnlaceSiguiente.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        public void EliminarNodo(string dato)
        {
            if (ValidaVacio() == false)
            {
                primero = Buscar(dato);
                if (ultimo != null)
                {
                    Nodo nodoAnterior = BuscarAnterior(dato);
                    nodoAnterior.EnlaceSiguiente = ultimo.EnlaceSiguiente;
                    ultimo.EnlaceSiguiente = nodoAnterior;
                }
            }
        }



    }
}
