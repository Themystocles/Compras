var Categorias = new Categorias();
Categorias.Titulo = "Eletronicos";
var novoItem = new Itens();
novoItem.Titulo = "Celular";
novoItem.Valor = 1.950;
novoItem.Descrição = "Descrição do item";

Categorias.Itens.Add(novoItem);

foreach (var item in Categorias.Itens)
{
    Console.WriteLine(item.Titulo);
}
