public class Itens
{

    public Itens()
    {
        Id = Guid.NewGuid();


    }
    public Guid Id { get; set; }
    public String Titulo { get; set; }
    public double Valor { get; set; }
    public string Descrição { get; set; }


}