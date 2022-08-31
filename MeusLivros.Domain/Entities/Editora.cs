namespace MeusLivros.Domain.Entities;

public class Editora : Entity
{
    public string Name { get; set; }

    public IList<Livro> Livros { get; set; }

    public Editora(string name)
    {
        Name = name;
        Livros = new List<Livro>();
    }
    public Editora(int id, string name)
    {
        Id = id;
        Name = name;
        Livros = new List<Livro>();
    }

    public Editora(int id)
    {
        Livros = new List<Livro>();
    }
}
