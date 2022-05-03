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

        public void AgregarNodo()
        {
            Nodo nuevoNodo = new Nodo();
            Console.WriteLine("Ingresar el valor del nuevo Nodo: ");
            nuevoNodo.Valor = int.Parse(Console.ReadLine());
            if(primero == null)

        }
    }
}
