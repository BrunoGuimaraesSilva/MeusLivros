using MeusLivros.Domain.Entities;
using System.Linq.Expressions;

namespace MeusLivros.Domain.Queries;

public class EditoraQueries
{
    public static Expression<Func<Editora, bool>> BuscaPorId(int Id)
    {
        return x => x.Id == Id;
    }
}
