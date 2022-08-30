using MeusLivros.Domain.Entities;
using System.Linq.Expressions;

namespace MeusLivros.Domain.Queries;

public class LivroQueries
{
    public static Expression<Func<Livro, bool>> BuscaPorId(int Id)
    {
        return livro => livro.Id == Id;
    }

    public static Expression<Func<Livro, bool>> BuscarTodosPorEditora(Editora editora)
    {
        return livro => livro.Editora == editora;
    }
}
