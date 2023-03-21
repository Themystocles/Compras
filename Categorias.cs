public class Categorias
{
    public Categorias()
    {
        Id = Guid.NewGuid();
    }



    public Guid Id { get; set; }
    public string Titulo { get; set; }

    public IList<Itens> Itens { get; set; }

}

