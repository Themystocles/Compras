var CategoriasEletronico = new Categorias("Eletronicos");

var CategoriasCozinha = new Categorias("Cozinha");

var Eletronicos = new Itens();
var Eletronicos1 = new Itens();
var Eletronicos2 = new Itens();
var Eletronicos3 = new Itens();

var CategoriasCozinha0 = new Itens();
var CategoriasCozinha1 = new Itens();
var CategoriasCozinha2 = new Itens();
var CategoriasCozinha3 = new Itens();


Eletronicos.Titulo = "Celular";
Eletronicos1.Titulo = "Tablet";
Eletronicos2.Titulo = "Pc";
Eletronicos3.Titulo = "Fone de ouvido";



CategoriasCozinha0.Titulo = "Torneiras";
CategoriasCozinha1.Titulo = "Quadros";
CategoriasCozinha2.Titulo = "Geladeiras";
CategoriasCozinha3.Titulo = "Fogão";

CategoriasEletronico.Itens.Add(CategoriasCozinha0);
CategoriasEletronico.Itens.Add(CategoriasCozinha1);
CategoriasEletronico.Itens.Add(CategoriasCozinha2);
CategoriasEletronico.Itens.Add(CategoriasCozinha3);



foreach (var itens in CategoriasEletronico.Itens)
{
    Console.WriteLine(itens.Titulo);
}





