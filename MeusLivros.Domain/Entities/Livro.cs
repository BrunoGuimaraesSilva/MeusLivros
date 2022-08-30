namespace MeusLivros.Domain.Entities;
public class Livro : Entity
{
    public string Name { get; set; }

    public int EditoraId { get; set; }
    public Editora Editora { get; set; }

    public Livro(string name, int editoraId)
    {
        Name = name;
        EditoraId = editoraId;
    }

    public Livro(int id, string name, int editoraId)
    {
        Id = id;
        Name = name;
        EditoraId = editoraId;
    }

    public Livro() { }
}
