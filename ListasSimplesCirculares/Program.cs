using ListasSimplesCirculares;

Lista listas = new Lista();
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
listas.AgregarNodo("Cuatro");
Console.WriteLine(listas.RecorrerLista());

listas.BuscarAnterior(listas.RecorrerLista());


Console.WriteLine("Eliminar Nodo");
listas.BorrarNodo("Tres");
Console.WriteLine(listas.RecorrerLista());

Console.WriteLine("Buscar Nodo");
Nodo nodoTres = listas.Buscar("Tres");
Console.WriteLine(nodoTres.Valor);
