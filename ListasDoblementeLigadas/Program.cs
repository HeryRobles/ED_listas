using ListasDoblementeLigadas;

Lista listas = new Lista();
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
Console.WriteLine(listas.RecorrerLista());

Console.WriteLine("Buscando Nodo");
Nodo nodoDos = listas.Buscar("Dos");
Console.WriteLine(nodoDos.Valor);
