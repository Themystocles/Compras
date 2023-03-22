public class Categorias
{
    public Categorias(string titulo)
    {
        Titulo = titulo;
        Id = Guid.NewGuid();
        Itens = new List<Itens>();
    }



    public Guid Id { get; set; }
    public string Titulo { get; set; }
    public IList<Itens> Itens { get; set; }

}

