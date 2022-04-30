using ListasSimplementeLigadas;

Lista listas = new Lista();
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Ocho");
Console.WriteLine(listas.RecorrerLista());

Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine("Buscando Nodo");
Nodo nodoDos = listas.Buscar("Dos");
Console.WriteLine(nodoDos.Valor);

Console.WriteLine();
Console.WriteLine("--------------------");

Console.WriteLine("Borrando Nodo");
listas.BorrarNodo("Dos");
Console.WriteLine(listas.RecorrerLista());

