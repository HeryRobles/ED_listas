using ListasDoblesCirculares;

Lista listas = new Lista();

listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
listas.AgregarNodo("Bardock");
Console.WriteLine(listas.RecorrerLista());

Console.WriteLine();
Console.WriteLine("--------------------");

Console.WriteLine("Buscando Nodo");
Nodo nodoBardock = listas.Buscar("Bardock");
Console.WriteLine(nodoBardock.Valor);

Console.WriteLine();
Console.WriteLine("--------------------");

Console.WriteLine("Borrando Nodo");
listas.EliminarNodo("Bardock");
Console.WriteLine(listas.RecorrerLista());

