using ListasDoblesCirculares;

Lista listas = new Lista();

listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
listas.AgregarNodo("Cuatro");
Console.WriteLine(listas.RecorrerLista());

Console.WriteLine();
Console.WriteLine("--------------------");

//Console.WriteLine("Buscando Nodo");
//Nodo nodoTres = listas.Buscar("Tres");
//Console.WriteLine(nodoTres.Valor);

//Console.WriteLine();
//Console.WriteLine("---------------");

//Console.WriteLine("Borrar Nodo");
//listas.EliminarNodo("Tres");
//Console.WriteLine(listas.RecorrerLista());